using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Fake_Name_Generator
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {

        Thread th;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGnr_Click(object sender, EventArgs e)
        {
            if(cmbGen.SelectedItem == null)
            {
                MessageBox.Show("Please Select Gender", "Important Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(cmbCon.SelectedItem == null)
            {
                MessageBox.Show("Please Select Country", "Important Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(txtAmnt.Text == "")
            {
                MessageBox.Show("Please Enter Amount", "Important Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //American
                if (cmbGen.Text == "Male" && cmbCon.Text == "American")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaAmerican.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if(cmbGen.Text == "Female" && cmbCon.Text == "American")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeAmerican.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Arabic
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Arabic")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaArabic.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Arabic")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeArabic.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Australian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Australian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaAustralian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Australian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeAustralian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Brazil
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Brazil")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaBrazil.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Brazil")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeBrazil.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Chinese
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Chinese")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaChinese.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Chinese")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeChinese.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Croatian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Croatian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaCroatian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Croatian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeCroatian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Czech
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Czech")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaCzech.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Czech")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeCzech.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Danish
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Danish")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaDanish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Danish")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeDanish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Dutch
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Dutch")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaDutch.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Dutch")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeDutch.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //England
                else if (cmbGen.Text == "Male" && cmbCon.Text == "England")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaEngland.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "England")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeEngland.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Eritrean
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Eritrean")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaEritrean.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Eritrean")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeEritrean.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Finnish
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Finnish")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaFinnish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Finnish")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeFinnish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //French
                else if (cmbGen.Text == "Male" && cmbCon.Text == "French")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaFrench.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "French")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeFrench.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //German
                else if (cmbGen.Text == "Male" && cmbCon.Text == "German")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaGerman.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "German")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeGerman.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Greenland
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Greenland")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaGreenland.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Greenland")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeGreenland.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Hungarian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Hungarian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaHungarian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Hungarian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeHungarian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Icelandic
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Icelandic")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaIcelandic.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Icelandic")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeIcelandic.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Italian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Italian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaItalian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Italian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeItalian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Japanese
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Japanese")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaJapanese.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Japanese")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeJapanese.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Norwegian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Norwegian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaNorwegian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Norwegian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeNorwegian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Persian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Persian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaPersian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Persian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FePersian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Polish
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Polish")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaPolish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Polish")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FePolish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Russian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Russian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaRussian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Russian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeRussian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Scottish
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Scottish")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaScottish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Scottish")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeScottish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Slovenian
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Slovenian")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaSlovenian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Slovenian")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeSlovenian.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Swedish
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Swedish")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaSwedish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Swedish")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeSwedish.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Thai
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Thai")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaThai.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Thai")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeThai.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                //Vietnamese
                else if (cmbGen.Text == "Male" && cmbCon.Text == "Vietnamese")
                {

                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "MaVietnamese.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }

                else if (cmbGen.Text == "Female" && cmbCon.Text == "Vietnamese")
                {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    Label.CheckForIllegalCrossThreadCalls = false;

                    th = new Thread(() =>
                    {
                        WaitTime();
                        txtres.Text = "FeVietnamese.txt";
                        lblReport.Visible = false;
                    });
                    th.Start();

                    lblReport.Visible = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "No Data Found")
                return;

            //American
            if (txtres.Text == "MaAmerican.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaAmerican.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if(txtres.Text == "FeAmerican.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeAmerican.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Arabic
            else if (txtres.Text == "MaArabic.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaArabic.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeArabic.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeArabic.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Australian
            else if (txtres.Text == "MaAustralian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaAustralian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeAustralian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeAustralian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }


            //Brazil
            else if (txtres.Text == "MaBrazil.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaBrazil.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeBrazil.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeBrazil.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }



            //Chinese
            else if (txtres.Text == "MaChinese.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaChinese.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeChinese.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeChinese.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Croatian
            else if (txtres.Text == "MaCroatian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaCroatian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeCroatian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeCroatian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Czech
            else if (txtres.Text == "MaCzech.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaCzech.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeCzech.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeCzech.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Danish
            else if (txtres.Text == "MaDanish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaDanish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeDanish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeDanish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Dutch
            else if (txtres.Text == "MaDutch.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaDutch.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeDutch.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeDutch.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //England
            else if (txtres.Text == "MaEngland.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaEngland.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeEngland.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeEngland.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Eritrean
            else if (txtres.Text == "MaEritrean.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaEritrean.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeEritrean.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeEritrean.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Finnish
            else if (txtres.Text == "MaFinnish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaFinnish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeFinnish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeFinnish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //French
            else if (txtres.Text == "MaFrench.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaFrench.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeFrench.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeFrench.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //German
            else if (txtres.Text == "MaGerman.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaGerman.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeGerman.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeGerman.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Greenland
            else if (txtres.Text == "MaGreenland.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaGreenland.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeGreenland.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeGreenland.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Hungarian
            else if (txtres.Text == "MaHungarian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaHungarian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeHungarian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeHungarian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Icelandic
            else if (txtres.Text == "MaIcelandic.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaIcelandic.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeIcelandic.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeIcelandic.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Italian
            else if (txtres.Text == "MaItalian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaItalian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeItalian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeItalian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Japanese
            else if (txtres.Text == "MaJapanese.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaJapanese.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeJapanese.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeJapanese.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Norwegian
            else if (txtres.Text == "MaNorwegian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaNorwegian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeNorwegian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeNorwegian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Persian
            else if (txtres.Text == "MaPersian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaPersian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FePersian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FePersian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Polish
            else if (txtres.Text == "MaPolish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaPolish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FePolish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FePolish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Russian
            else if (txtres.Text == "MaRussian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaRussian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeRussian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeRussian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Scottish
            else if (txtres.Text == "MaScottish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaScottish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeScottish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeScottish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Slovenian
            else if (txtres.Text == "MaSlovenian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaSlovenian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeSlovenian.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeSlovenian.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Swedish
            else if (txtres.Text == "MaSwedish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaSwedish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeSwedish.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeSwedish.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            
            //Thai
            else if (txtres.Text == "MaThai.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaThai.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeThai.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeThai.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            //Vietnamese
            else if (txtres.Text == "MaVietnamese.txt")
            {
                var logFile = File.ReadAllLines(@"Name/MaVietnamese.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }

            else if (txtres.Text == "FeVietnamese.txt")
            {
                var logFile = File.ReadAllLines(@"Name/FeVietnamese.txt");

                string[] amount = logFile.Take(int.Parse(txtAmnt.Text)).Select(i => i.ToString()).ToArray();


                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    sfd.FileName = txtres.Text;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            foreach (String s in amount)
                                tw.WriteLine(s);
                        }
                    }
                }
            }
        }

        private void WaitTime()
        {
            Thread.Sleep(500);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbGen.SelectedIndex = -1;
            cmbCon.SelectedIndex = -1;
            txtAmnt.Text = null;
            txtres.Text = "No Data Found";
        }

        private void txtAmnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
