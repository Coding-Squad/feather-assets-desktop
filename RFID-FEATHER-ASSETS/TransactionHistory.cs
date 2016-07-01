using Microsoft.Win32;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_FEATHER_ASSETS
{
    public partial class TransactionHistory : Form
    {
        string tokenValue;
        string roleValue;
        int companyId;
        string startDate;
        string endDate;
        public int assetId;
        int userId;

        public TransactionHistory()
        {
            InitializeComponent();
            GetAssetSystemInfo();
        }

        private void GetAssetSystemInfo()
        {
            try
            {
                //opening the subkey  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AssetSystemInfo");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    tokenValue = (string)(key.GetValue("authenticationToken"));
                    roleValue = (string)(key.GetValue("roles"));
                    companyId = (int)(key.GetValue("companyId"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                grdViewTransactions.Rows.Clear();
                grdViewTransactions.Refresh();

                lblLoadingInformation.Text = "Getting Information. Please wait...";
                lblLoadingInformation.Visible = true;
                lblLoadingInformation.Refresh();

                startDate = dtDateFromPicker.Value.ToString("yyyy-MM-ddT00:01");
                endDate = dtDateToPicker.Value.ToString("yyyy-MM-ddT23:59");
                if (!string.IsNullOrEmpty(txtAssetID.Text.Trim())) assetId = int.Parse(txtAssetID.Text.Trim());
                if (!string.IsNullOrEmpty(txtUserID.Text.Trim())) userId = int.Parse(txtUserID.Text.Trim());

                //initialize Rest Client
                RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
                RestRequest transactionInfo = new RestRequest("/api/transaction/search?startDate=" + startDate + "&endDate=" + endDate /*+ "&assetId=" + assetId*/, Method.GET);

                var authToken = tokenValue;

                //add needed headers
                transactionInfo.RequestFormat = DataFormat.Json;
                transactionInfo.AddHeader("Content-Type", "application/json; charset=utf-8");
                transactionInfo.AddHeader("X-Auth-Token", authToken);

                //execute request
                var response = client.Execute<List<GenerateResult>>(transactionInfo);
                var content = response.Content;

                lblLoadingInformation.Visible = false;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //deserialize json response into object
                    JsonDeserializer deserial = new JsonDeserializer();
                    List<GenerateResult> generateResult = deserial.Deserialize<List<GenerateResult>>(response);

                    string ValidUntil;

                    if (generateResult.Count != 0)
                    {
                        grdViewTransactions.ColumnHeadersVisible = true;

                        for (int i = 0; i < generateResult.Count; i++)
                        {
                            int idx = grdViewTransactions.Rows.Add();
                            DataGridViewRow row = grdViewTransactions.Rows[idx];

                            row.Cells["ColTransId"].Value = generateResult[i].transactionId;
                            row.Cells["ColAssetId"].Value = generateResult[i].asset.assetId ?? null;
                            row.Cells["ColCompanyId"].Value = generateResult[i].asset.companyId ?? null;
                            row.Cells["ColRegisterId"].Value = generateResult[i].asset.registerUserId ?? null;
                            row.Cells["ColUpdateId"].Value = generateResult[i].asset.updateUserId ?? null;
                            row.Cells["ColDescription"].Value = generateResult[i].asset.description;
                            row.Cells["ColImgUrl"].Value = generateResult[i].asset.imageUrls;
                            row.Cells["ColRFIDTag"].Value = generateResult[i].asset.tag;
                            row.Cells["ColTakeOutNote"].Value = generateResult[i].asset.takeOutInfo;

                            ValidUntil = generateResult[i].asset.validUntil != DateTime.MinValue ? generateResult[i].asset.validUntil.ToString("g") : "No Expiration";
                            row.Cells["ColValidUntil"].Value = ValidUntil;

                            row.Cells["ColNotes"].Value = generateResult[i].notes;
                            row.Cells["ColPersonImgUrl"].Value = generateResult[i].imageUrl;
                            row.Cells["ColCreatedAt"].Value = generateResult[i].createdAt;
                            row.Cells["ColUpdatedAt"].Value = generateResult[i].asset.updatedAt;

                            //grdViewTransactions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
                            //return;
                        }
                    }
                    else
                    {
                        grdViewTransactions.ColumnHeadersVisible = false;
                        lblLoadingInformation.Text = "Transaction not found.";
                        lblLoadingInformation.Visible = true;
                        //lblLoadingInformation.Refresh();
                    }

                }
                else 
                {
                    MessageBox.Show("Error connecting to server.. please try again later");
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CallMainMenu();
        }

        private void TransactionHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            CallMainMenu();
        }

        private void CallMainMenu()
        {
            this.Hide();
            MainMenu MenuForm = new MainMenu(tokenValue, roleValue);
            MenuForm.Show();
        }

       
    }

    public class GenerateResult
    {
        //public int? assetId { get; set; }
        public int transactionId { get; set; }
        public string notes { get; set; }
        public string imageUrl { get; set; }
        public string createdAt { get; set; }
        public string result { get; set; }
        public string message { get; set; }
        public AssetList asset { get; set; }
    }

    public class AssetList
    {
        public int? assetId { get; set; }
        public int? companyId { get; set; }
        public int? registerUserId { get; set; }
        public int? updateUserId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageUrls { get; set; }
        public string tag { get; set; }
        public string takeOutInfo { get; set; }
        public string updatedAt { get; set; }
        public DateTime validUntil { get; set; }
    }
}
