namespace TestesCampbell
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbTipoChamada = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            tbResposta = new TextBox();
            panel = new Panel();
            label3 = new Label();
            cbFormato = new ComboBox();
            bt1 = new Button();
            SuspendLayout();
            // 
            // cbTipoChamada
            // 
            cbTipoChamada.FormattingEnabled = true;
            cbTipoChamada.Location = new Point(57, 50);
            cbTipoChamada.Name = "cbTipoChamada";
            cbTipoChamada.Size = new Size(121, 23);
            cbTipoChamada.TabIndex = 1;
            cbTipoChamada.SelectedIndexChanged += cbTipoChamada_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo Chamada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 318);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Resposta";
            // 
            // tbResposta
            // 
            tbResposta.BorderStyle = BorderStyle.FixedSingle;
            tbResposta.Location = new Point(44, 345);
            tbResposta.Multiline = true;
            tbResposta.Name = "tbResposta";
            tbResposta.ScrollBars = ScrollBars.Vertical;
            tbResposta.Size = new Size(932, 296);
            tbResposta.TabIndex = 4;
            // 
            // panel
            // 
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(57, 95);
            panel.Name = "panel";
            panel.Size = new Size(900, 140);
            panel.TabIndex = 5;
            panel.Paint += panel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(744, 32);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Formato";
            // 
            // cbFormato
            // 
            cbFormato.FormattingEnabled = true;
            cbFormato.Location = new Point(744, 50);
            cbFormato.Name = "cbFormato";
            cbFormato.Size = new Size(121, 23);
            cbFormato.TabIndex = 6;
            // 
            // bt1
            // 
            bt1.Location = new Point(374, 268);
            bt1.Name = "bt1";
            bt1.Size = new Size(260, 40);
            bt1.TabIndex = 8;
            bt1.Text = "Realizar Chamada";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 686);
            Controls.Add(bt1);
            Controls.Add(label3);
            Controls.Add(cbFormato);
            Controls.Add(panel);
            Controls.Add(tbResposta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTipoChamada);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbTipoChamada;
        private Label label1;
        private Label label2;
        private TextBox tbResposta;
        private Panel panel;
        private Label label3;
        private ComboBox cbFormato;
        private Button bt1;
    }
}