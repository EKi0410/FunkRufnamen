
namespace Rufnamen
{
    partial class btnFzgenerieren
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnFzgenerieren));
            this.header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bundesland = new System.Windows.Forms.Label();
            this.lblFzgwahl = new System.Windows.Forms.Label();
            this.fzliste = new System.Windows.Forms.CheckedListBox();
            this.inputFzgleichertyp = new System.Windows.Forms.TextBox();
            this.lblFzgleichertyp = new System.Windows.Forms.Label();
            this.lblStadname = new System.Windows.Forms.Label();
            this.inputStadtname = new System.Windows.Forms.TextBox();
            this.btnFznamegen = new System.Windows.Forms.Button();
            this.lblFznamefertig = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otlabel = new System.Windows.Forms.Label();
            this.inputOtziffer = new System.Windows.Forms.TextBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(465, 12);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(287, 45);
            this.header.TabIndex = 1;
            this.header.Text = "Funkrufnamen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "@Jan-Erik Stern / Eki0410";
            // 
            // bundesland
            // 
            this.bundesland.AutoSize = true;
            this.bundesland.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bundesland.Location = new System.Drawing.Point(330, 69);
            this.bundesland.Name = "bundesland";
            this.bundesland.Size = new System.Drawing.Size(258, 18);
            this.bundesland.TabIndex = 3;
            this.bundesland.Text = "Aktuelles Bundesland: Hessen";
            // 
            // lblFzgwahl
            // 
            this.lblFzgwahl.AutoSize = true;
            this.lblFzgwahl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFzgwahl.Location = new System.Drawing.Point(330, 107);
            this.lblFzgwahl.Name = "lblFzgwahl";
            this.lblFzgwahl.Size = new System.Drawing.Size(181, 18);
            this.lblFzgwahl.TabIndex = 4;
            this.lblFzgwahl.Text = "Fahrzeug auswählen:";
            this.lblFzgwahl.Click += new System.EventHandler(this.lblFzgwahl_Click);
            // 
            // fzliste
            // 
            this.fzliste.CheckOnClick = true;
            this.fzliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fzliste.FormattingEnabled = true;
            this.fzliste.Items.AddRange(new object[] {
            "LF 10",
            "LF 20",
            "LF 8/6",
            "LF 20/16",
            "LF 10/6",
            "LF 16-TS",
            "HLF 20",
            "HLF 10",
            "TSF-W",
            "KLF",
            "MLF",
            "TLF 2000",
            "TLF 3000",
            "TLF 8/8",
            "TLF 8/18",
            "TLF 16/24-Tr",
            "TLF 16/25",
            "TLF 16/45",
            "TLF 20/40",
            "TLF 20/40-SL",
            "TLF 16",
            "ELW 1",
            "ELW 2",
            "DLK",
            "RW",
            "SW 1000",
            "SW 2000",
            "SW 2000-Tr",
            "SW-KatS",
            "GW-L2-Wasser",
            "GW-A",
            "GW-G",
            "GW-Mess",
            "GW-ÖL",
            "GW-H",
            "GW Dekon-P",
            "MTF",
            "WLF",
            "FwK"});
            this.fzliste.Location = new System.Drawing.Point(333, 128);
            this.fzliste.Name = "fzliste";
            this.fzliste.Size = new System.Drawing.Size(178, 340);
            this.fzliste.TabIndex = 5;
            this.fzliste.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // inputFzgleichertyp
            // 
            this.inputFzgleichertyp.Location = new System.Drawing.Point(531, 184);
            this.inputFzgleichertyp.Name = "inputFzgleichertyp";
            this.inputFzgleichertyp.Size = new System.Drawing.Size(61, 20);
            this.inputFzgleichertyp.TabIndex = 6;
            this.inputFzgleichertyp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFzgleichertyp
            // 
            this.lblFzgleichertyp.AutoSize = true;
            this.lblFzgleichertyp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFzgleichertyp.Location = new System.Drawing.Point(528, 163);
            this.lblFzgleichertyp.Name = "lblFzgleichertyp";
            this.lblFzgleichertyp.Size = new System.Drawing.Size(203, 18);
            this.lblFzgleichertyp.TabIndex = 7;
            this.lblFzgleichertyp.Text = "Anzahl Fz. gleicher Typ:";
            // 
            // lblStadname
            // 
            this.lblStadname.AutoSize = true;
            this.lblStadname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadname.Location = new System.Drawing.Point(528, 107);
            this.lblStadname.Name = "lblStadname";
            this.lblStadname.Size = new System.Drawing.Size(104, 18);
            this.lblStadname.TabIndex = 8;
            this.lblStadname.Text = "Stadtname:";
            // 
            // inputStadtname
            // 
            this.inputStadtname.Location = new System.Drawing.Point(531, 128);
            this.inputStadtname.Name = "inputStadtname";
            this.inputStadtname.Size = new System.Drawing.Size(200, 20);
            this.inputStadtname.TabIndex = 9;
            this.inputStadtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnFznamegen
            // 
            this.btnFznamegen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFznamegen.Location = new System.Drawing.Point(531, 334);
            this.btnFznamegen.Name = "btnFznamegen";
            this.btnFznamegen.Size = new System.Drawing.Size(260, 46);
            this.btnFznamegen.TabIndex = 10;
            this.btnFznamegen.Text = "Fz. Name generieren u. in die Zwischenablage speichern\r\n";
            this.btnFznamegen.UseVisualStyleBackColor = true;
            this.btnFznamegen.Click += new System.EventHandler(this.btnFznamegen_Click);
            // 
            // lblFznamefertig
            // 
            this.lblFznamefertig.AutoSize = true;
            this.lblFznamefertig.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFznamefertig.Location = new System.Drawing.Point(527, 392);
            this.lblFznamefertig.Name = "lblFznamefertig";
            this.lblFznamefertig.Size = new System.Drawing.Size(0, 23);
            this.lblFznamefertig.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rufnamen.Properties.Resources.pexels_markus_spiske_3058827;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // otlabel
            // 
            this.otlabel.AutoSize = true;
            this.otlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otlabel.Location = new System.Drawing.Point(528, 223);
            this.otlabel.Name = "otlabel";
            this.otlabel.Size = new System.Drawing.Size(119, 18);
            this.otlabel.TabIndex = 12;
            this.otlabel.Text = "Ortsteilziffer:";
            this.toolTip2.SetToolTip(this.otlabel, "Hier musst du die Ortsteilziffer eingeben, meistens setzt diese sich aus der Alph" +
        "abetischen reihenfolge der einzelnen Ortsteile zusammen.\r\nBspw. Stadt Niddatal: " +
        "1=Assenheim, 2=>Bönstadt, ...\r\n\r\n");
            // 
            // inputOtziffer
            // 
            this.inputOtziffer.Location = new System.Drawing.Point(531, 244);
            this.inputOtziffer.Name = "inputOtziffer";
            this.inputOtziffer.Size = new System.Drawing.Size(61, 20);
            this.inputOtziffer.TabIndex = 13;
            this.inputOtziffer.TextChanged += new System.EventHandler(this.inputOtziffer_TextChanged);
            // 
            // toolTip2
            // 
            this.toolTip2.ShowAlways = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnFzgenerieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 489);
            this.Controls.Add(this.inputOtziffer);
            this.Controls.Add(this.otlabel);
            this.Controls.Add(this.lblFznamefertig);
            this.Controls.Add(this.btnFznamegen);
            this.Controls.Add(this.inputStadtname);
            this.Controls.Add(this.lblStadname);
            this.Controls.Add(this.lblFzgleichertyp);
            this.Controls.Add(this.inputFzgleichertyp);
            this.Controls.Add(this.fzliste);
            this.Controls.Add(this.lblFzgwahl);
            this.Controls.Add(this.bundesland);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnFzgenerieren";
            this.RightToLeftLayout = true;
            this.Text = "Funkrufnamen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bundesland;
        private System.Windows.Forms.Label lblFzgwahl;
        private System.Windows.Forms.CheckedListBox fzliste;
        private System.Windows.Forms.TextBox inputFzgleichertyp;
        private System.Windows.Forms.Label lblFzgleichertyp;
        private System.Windows.Forms.Label lblStadname;
        private System.Windows.Forms.TextBox inputStadtname;
        private System.Windows.Forms.Button btnFznamegen;
        private System.Windows.Forms.Label lblFznamefertig;
        private System.Windows.Forms.Label otlabel;
        private System.Windows.Forms.TextBox inputOtziffer;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

