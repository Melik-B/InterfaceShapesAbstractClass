using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceShapesAbstractClass
{
    public partial class Form1 : Form
    {
        #region Form kenar yuvarlaklaştırma
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

        public Point mouseLocation;
        #endregion

        bool Daire = true;
        bool Diger = false;
        bool Dortgen = false;
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlIslem.Items.Add("Alan");
            ddlIslem.Items.Add("Çevre");
            ddlIslem.SelectedIndex = 0;
        }

        #region Form sürükleme
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        #endregion

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbYaricap_MouseClick(object sender, MouseEventArgs e)
        {
            lbYaricap.Visible = false;
        }

        private void btDikUcgen_Click(object sender, EventArgs e)
        {
            tbGenislik.Text = "";
            tbYukseklik.Text = "";
            lbGenislik.Visible = true;
            lbYukseklik.Visible = true;
            lbSonuc.Visible = false;
            lbHata.Visible = false;
            pbDaire.Visible = false;
            pbKare.Visible = false;
            pbUcgen.Location = new Point(605, 12);
            pbUcgen.Visible = true;
            Diger = true;
            Daire = false;
            pbDiger.Location = new Point(600, 235);
            pbDiger.Visible = true;
            pDaire.Visible = false;
        }

        private void btDortgen_Click(object sender, EventArgs e)
        {
            tbGenislik.Text = "";
            tbYukseklik.Text = "";
            lbGenislik.Visible = true;
            lbYukseklik.Visible = true;
            lbSonuc.Visible = false;
            lbHata.Visible = false;
            pbKare.Location = new Point(605, 12);
            pbKare.Visible = true;
            pbDaire.Visible = false;
            pbUcgen.Visible = false;
            Dortgen = true;
            Daire = false;
            pbDiger.Location = new Point(600, 235);
            pbDiger.Visible = true;
            pDaire.Visible = false;
        }

        private void btDaire_Click(object sender, EventArgs e)
        {
            lbSonuc.Visible = false;
            lbHata.Visible = false;
            pbDaire.Visible = true;
            pbUcgen.Visible = false;
            pbKare.Visible = false;
            Diger = false;
            Daire = true;
            pDaire.Visible = true;
            pbDiger.Visible = false;
        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            btHesapla.Location = new Point(692, 420);
            lbSonuc.Location = new Point(735, 390);
            lbSonuc.Text = "Sonuç: ";
            double sonuc = 0;
            IRoundedShapeBase roundedShape;
            IShapeWithAnglesBase shapeWithAngles;

            if (Daire == true)
            {
                if (string.IsNullOrWhiteSpace(tbYaricap.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(617, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Yarıçap boş bırakılamaz !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }
                if (!GirisKontrol(tbYaricap.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(617, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Yarıçap sayısal olmalıdır !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }

                roundedShape = new Circle()
                {
                    Radius = Convert.ToDouble(tbYaricap.Text, new CultureInfo("tr")),
                    IsPiThree = cbPI3.Checked
                };
                if (ddlIslem.SelectedIndex == 0 && !string.IsNullOrWhiteSpace(tbYaricap.Text) && GirisKontrol(tbYaricap.Text))
                {
                    lbHata.Visible = false;
                    ddlIslem.Location = new Point(617, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbSonuc.Location = new Point(745, 335);
                    lbSonuc.Visible = true;
                    sonuc = roundedShape.CalculateArea();
                }
                else if(ddlIslem.SelectedIndex == 1 && !string.IsNullOrWhiteSpace(tbYaricap.Text) && GirisKontrol(tbYaricap.Text))
                {
                    lbHata.Visible = false;
                    ddlIslem.Location = new Point(617, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbSonuc.Location = new Point(745, 335);
                    lbSonuc.Visible = true;
                    sonuc = roundedShape.CalculateCircumference();
                }
            }
            else if (Dortgen)
            {
                if (string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Yükseklik boş bırakılamaz !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }
                else if (string.IsNullOrWhiteSpace(tbGenislik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Genişlik boş bırakılamaz !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }
                else if (!GirisKontrol(tbYukseklik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Yükseklik sayısal olmalıdır !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }
                else if (!GirisKontrol(tbGenislik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Genişlik sayısal olmalıdır !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }

                shapeWithAngles = new Rectangle
                {
                    Height = Convert.ToDouble(tbYukseklik.Text, new CultureInfo("tr")),
                    Width = Convert.ToDouble(tbGenislik.Text, new CultureInfo("tr"))
                };
                if (ddlIslem.SelectedIndex == 0 && !string.IsNullOrWhiteSpace(tbYukseklik.Text) && !string.IsNullOrWhiteSpace(tbGenislik.Text) && GirisKontrol(tbGenislik.Text) && GirisKontrol(tbYukseklik.Text))
                {
                    lbSonuc.Visible = true;
                    lbHata.Visible = false;
                    sonuc = shapeWithAngles.CalculateArea();
                }
                else if(ddlIslem.SelectedIndex == 1 && !string.IsNullOrWhiteSpace(tbYukseklik.Text) && !string.IsNullOrWhiteSpace(tbGenislik.Text) && GirisKontrol(tbGenislik.Text) && GirisKontrol(tbYukseklik.Text))
                {
                    lbSonuc.Visible = true;
                    lbHata.Visible = false;
                    sonuc = shapeWithAngles.CalcuteCircumference();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbYukseklik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Yükseklik boş bırakılamaz !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }
                else if (string.IsNullOrWhiteSpace(tbGenislik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Genişlik boş bırakılamaz !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }
                else if (!GirisKontrol(tbYukseklik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Yükseklik sayısal olmalıdır !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }
                else if (!GirisKontrol(tbGenislik.Text))
                {
                    lbSonuc.Visible = false;
                    ddlIslem.Location = new Point(615, 360);
                    btHesapla.Location = new Point(692, 390);
                    lbHata.Text = "Genişlik sayısal olmalıdır !";
                    lbHata.Location = new Point(613, 335);
                    lbHata.Visible = true;
                    return;
                }

                shapeWithAngles = new RightTriangle()
                {
                    Height = Convert.ToDouble(tbYukseklik.Text, new CultureInfo("tr")),
                    Width = Convert.ToDouble(tbGenislik.Text, new CultureInfo("tr"))
                };
                if(ddlIslem.SelectedIndex == 0 && !string.IsNullOrWhiteSpace(tbYukseklik.Text) && !string.IsNullOrWhiteSpace(tbGenislik.Text) && GirisKontrol(tbYukseklik.Text) && GirisKontrol(tbGenislik.Text))
                {
                    lbHata.Visible = false;
                    lbSonuc.Visible = true;
                    sonuc = shapeWithAngles.CalculateArea();
                }
                else if(ddlIslem.SelectedIndex == 1 && !string.IsNullOrWhiteSpace(tbYukseklik.Text) && !string.IsNullOrWhiteSpace(tbGenislik.Text) && GirisKontrol(tbYukseklik.Text) && GirisKontrol(tbGenislik.Text))
                {
                    lbHata.Visible = false;
                    lbSonuc.Visible = true;
                    sonuc = shapeWithAngles.CalcuteCircumference();
                }
            }
            lbSonuc.Text += sonuc.ToString(new CultureInfo("tr"));
        }

        bool GirisKontrol(string giris)
        {
            double sayi;
            bool sonuc = double.TryParse(giris, NumberStyles.Any, new CultureInfo("tr"), out sayi);
            return sonuc;
        }

        private void tbGenislik_MouseClick(object sender, MouseEventArgs e)
        {
            lbGenislik.Visible = false;
        }

        private void tbYukseklik_MouseClick(object sender, MouseEventArgs e)
        {
            lbYukseklik.Visible = false;
        }
    }
}