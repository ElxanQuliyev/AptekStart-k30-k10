using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhymarcyApp_K30.Model;

namespace PhymarcyApp_K30
{
    public partial class AddMedicine : Form
    {
        AptekDBEntities db = new AptekDBEntities();
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            FillFirms();
            FillDataGridMedicine();
        }
        private void FillFirms()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(a => a.Name).ToArray());
        }


        private void FillDataGridMedicine()
        {
            dtgAddMedicine.DataSource = db.Medicines.Where(m => m.Count > 0)
                .Select(m => new
                {
                    Name = m.Name,
                    QrCode = m.Qr_Code,
                    WithReceipt = m.WithReceipt == 0 ? "Reseptsiz" : "Reseptli",
                    ProDate = m.Pro_date,
                    Valid_Date = m.Valid_date,
                    Firms = m.Firm.Name,
                    Price = m.Price + " AZN",
                    Count = m.Count,
                }).ToList();
            for (var i = 0; i < dtgAddMedicine.RowCount; i++)
            {
                DateTime valDate = (DateTime)dtgAddMedicine.Rows[i].Cells[4].Value;
                if (valDate < DateTime.Now)
                {
                    dtgAddMedicine.Rows[i].DefaultCellStyle.BackColor = Color.Brown;
                    dtgAddMedicine.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
            }
        }
        private int checkFirm(string firmName)
        {
            Firm frm = db.Firms.FirstOrDefault(fr => fr.Name == firmName);
            if (frm != null)
            {
                return frm.Id;
            }
            Firm addedFirm = db.Firms.Add(new Firm { Name = firmName });
            db.SaveChanges();
            return addedFirm.Id;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string name = txtMedicine.Text;
            string QrCode =nmQrCode.Value.ToString();
            string Desc = richDescription.Text;
            bool withReceipt = ckReseipt.Checked;
            decimal price = nmPrice.Value;
            int count = (int)nmCount.Value;
            DateTime productionDate = dtproductDate.Value;
            DateTime validDate = dtValidDate.Value;
            string firms = cmbFirms.Text;
            if (Extencies.IsNotEmpty(new string[] {
                Name,QrCode,firms
            },string.Empty))
            {
                if (QrCode.Length == 5)
                {
                    if (price > 0 && count > 0)
                    {
                        int firmId = checkFirm(firms);
                        Medicine md = new Medicine
                        {
                            Name = name,
                            Qr_Code = QrCode,
                            Description = Desc,
                            WithReceipt = Convert.ToByte(withReceipt),
                            Price = price,
                            Count = count,
                            Pro_date = productionDate,
                            Valid_date = validDate,
                            Firm_Id = firmId
                        };
                        db.Medicines.Add(md);
                        db.SaveChanges();
                        MessageBox.Show("Was successfully edit " + md.Name + " to Phymarcy list", "Succeffuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    lblError.Text = "QrCode should be 13 length Charachter";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please Fill Input";
                lblError.Visible = true;
            }

            
        }
    }
}
