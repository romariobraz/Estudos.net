namespace Janela.MainWindow
{
    partial class JanelaCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSomar = new System.Windows.Forms.Button();
            this.BtnSubtrair = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnSeno = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.BtnLimparMemo = new System.Windows.Forms.Button();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.BtnPorcentagem = new System.Windows.Forms.Button();
            this.HistoricoTextBox = new System.Windows.Forms.RichTextBox();
            this.BtnLimparHistorico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSomar
            // 
            this.BtnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSomar.Location = new System.Drawing.Point(574, 12);
            this.BtnSomar.Name = "BtnSomar";
            this.BtnSomar.Size = new System.Drawing.Size(102, 65);
            this.BtnSomar.TabIndex = 13;
            this.BtnSomar.Tag = "+";
            this.BtnSomar.Text = "Somar";
            this.BtnSomar.UseVisualStyleBackColor = true;
            this.BtnSomar.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // BtnSubtrair
            // 
            this.BtnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtrair.Location = new System.Drawing.Point(682, 12);
            this.BtnSubtrair.Name = "BtnSubtrair";
            this.BtnSubtrair.Size = new System.Drawing.Size(102, 65);
            this.BtnSubtrair.TabIndex = 14;
            this.BtnSubtrair.Tag = "-";
            this.BtnSubtrair.Text = "Subtrair";
            this.BtnSubtrair.UseVisualStyleBackColor = true;
            this.BtnSubtrair.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicar.Location = new System.Drawing.Point(574, 83);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(102, 65);
            this.BtnMultiplicar.TabIndex = 15;
            this.BtnMultiplicar.Tag = "*";
            this.BtnMultiplicar.Text = "Multiplicar";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDividir.Location = new System.Drawing.Point(682, 83);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(102, 65);
            this.BtnDividir.TabIndex = 16;
            this.BtnDividir.Tag = "/";
            this.BtnDividir.Text = "Divisão";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(574, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 65);
            this.button4.TabIndex = 17;
            this.button4.Tag = "Resto";
            this.button4.Text = "Divisão  (Resto)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(682, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 65);
            this.button5.TabIndex = 18;
            this.button5.Tag = "^";
            this.button5.Text = "Potencia";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // BtnSeno
            // 
            this.BtnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeno.Location = new System.Drawing.Point(682, 155);
            this.BtnSeno.Name = "BtnSeno";
            this.BtnSeno.Size = new System.Drawing.Size(102, 65);
            this.BtnSeno.TabIndex = 19;
            this.BtnSeno.Tag = "seno";
            this.BtnSeno.Text = "Seno";
            this.BtnSeno.UseVisualStyleBackColor = true;
            this.BtnSeno.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(574, 226);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 65);
            this.button7.TabIndex = 20;
            this.button7.Tag = "cosseno";
            this.button7.Text = "Coseno";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(682, 226);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 65);
            this.button8.TabIndex = 21;
            this.button8.Tag = "tangente";
            this.button8.Text = "Tangente";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(574, 298);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 65);
            this.button9.TabIndex = 22;
            this.button9.Tag = "Raiz";
            this.button9.Text = "Raiz";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(682, 440);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 65);
            this.button10.TabIndex = 23;
            this.button10.Tag = "IMC";
            this.button10.Text = "IMC";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(574, 369);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(102, 65);
            this.button11.TabIndex = 24;
            this.button11.Tag = "Fibonacci";
            this.button11.Text = "Fibonacci";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(682, 367);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(102, 65);
            this.button13.TabIndex = 26;
            this.button13.Tag = "Raio";
            this.button13.Text = "Raio";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(233, 12);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(335, 136);
            this.TextBox1.TabIndex = 28;
            this.TextBox1.Text = "";
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(233, 154);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(102, 65);
            this.Btn1.TabIndex = 29;
            this.Btn1.Tag = "1";
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.Location = new System.Drawing.Point(233, 438);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(102, 65);
            this.BtnIgual.TabIndex = 38;
            this.BtnIgual.Tag = "=";
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnLimparMemo
            // 
            this.BtnLimparMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimparMemo.Location = new System.Drawing.Point(341, 438);
            this.BtnLimparMemo.Name = "BtnLimparMemo";
            this.BtnLimparMemo.Size = new System.Drawing.Size(102, 65);
            this.BtnLimparMemo.TabIndex = 39;
            this.BtnLimparMemo.Text = "Limpar Memória";
            this.BtnLimparMemo.UseVisualStyleBackColor = true;
            this.BtnLimparMemo.Click += new System.EventHandler(this.BtnLimparMemo_Click);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackspace.Location = new System.Drawing.Point(449, 438);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(102, 65);
            this.BtnBackspace.TabIndex = 40;
            this.BtnBackspace.Tag = "Backspace";
            this.BtnBackspace.Text = "Backspace";
            this.BtnBackspace.UseVisualStyleBackColor = true;
            this.BtnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(341, 367);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(102, 65);
            this.Btn0.TabIndex = 41;
            this.Btn0.Tag = "0";
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(341, 154);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(102, 65);
            this.Btn2.TabIndex = 44;
            this.Btn2.Tag = "2";
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(449, 155);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(102, 65);
            this.Btn3.TabIndex = 45;
            this.Btn3.Tag = "3";
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(449, 226);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(102, 65);
            this.Btn6.TabIndex = 48;
            this.Btn6.Tag = "6";
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(341, 225);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(102, 65);
            this.Btn5.TabIndex = 47;
            this.Btn5.Tag = "5";
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(233, 225);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(102, 65);
            this.Btn4.TabIndex = 46;
            this.Btn4.Tag = "4";
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(449, 298);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(102, 65);
            this.Btn9.TabIndex = 51;
            this.Btn9.Tag = "9";
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(341, 297);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(102, 65);
            this.Btn8.TabIndex = 50;
            this.Btn8.Tag = "8";
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(233, 297);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(102, 65);
            this.Btn7.TabIndex = 49;
            this.Btn7.Tag = "7";
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Location = new System.Drawing.Point(790, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 268);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversor de Temperaturas";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 65);
            this.button1.TabIndex = 64;
            this.button1.Tag = "FC";
            this.button1.Text = "Fahrenheit > Celsius";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 65);
            this.button2.TabIndex = 63;
            this.button2.Tag = "FK";
            this.button2.Text = "Fahrenheit > Kelvin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(123, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 65);
            this.button3.TabIndex = 62;
            this.button3.Tag = "KC";
            this.button3.Text = "Kelvin > Celsius";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(15, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 65);
            this.button6.TabIndex = 61;
            this.button6.Tag = "KF";
            this.button6.Text = "Kelvin > Fahrenheit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(123, 30);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(102, 65);
            this.button12.TabIndex = 60;
            this.button12.Tag = "CK";
            this.button12.Text = "Celsius > Kelvin";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(15, 30);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(102, 65);
            this.button14.TabIndex = 59;
            this.button14.Tag = "CF";
            this.button14.Text = "Celsius > Fahrenheit";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Location = new System.Drawing.Point(790, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 209);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular Area";
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(73, 120);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(102, 65);
            this.button18.TabIndex = 61;
            this.button18.Tag = "Circulo";
            this.button18.Text = "Circulo";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(123, 49);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(102, 65);
            this.button19.TabIndex = 60;
            this.button19.Tag = "Retangulo";
            this.button19.Text = "Retangulo";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(15, 49);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(102, 65);
            this.button20.TabIndex = 59;
            this.button20.Tag = "Quadrado";
            this.button20.Text = "Quadrado";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.BtnOperacaoUnaria_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(233, 367);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(102, 65);
            this.button15.TabIndex = 66;
            this.button15.Tag = ",";
            this.button15.Text = ",";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.BtnNumero_Click);
            // 
            // BtnPorcentagem
            // 
            this.BtnPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPorcentagem.Location = new System.Drawing.Point(449, 369);
            this.BtnPorcentagem.Name = "BtnPorcentagem";
            this.BtnPorcentagem.Size = new System.Drawing.Size(102, 65);
            this.BtnPorcentagem.TabIndex = 67;
            this.BtnPorcentagem.Tag = "%";
            this.BtnPorcentagem.Text = "%";
            this.BtnPorcentagem.UseVisualStyleBackColor = true;
            this.BtnPorcentagem.Click += new System.EventHandler(this.BtnOperacaoBinaria_Click);
            // 
            // HistoricoTextBox
            // 
            this.HistoricoTextBox.Location = new System.Drawing.Point(12, 36);
            this.HistoricoTextBox.Name = "HistoricoTextBox";
            this.HistoricoTextBox.ReadOnly = true;
            this.HistoricoTextBox.Size = new System.Drawing.Size(215, 390);
            this.HistoricoTextBox.TabIndex = 68;
            this.HistoricoTextBox.Text = "";
            // 
            // BtnLimparHistorico
            // 
            this.BtnLimparHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimparHistorico.Location = new System.Drawing.Point(12, 440);
            this.BtnLimparHistorico.Name = "BtnLimparHistorico";
            this.BtnLimparHistorico.Size = new System.Drawing.Size(215, 63);
            this.BtnLimparHistorico.TabIndex = 69;
            this.BtnLimparHistorico.Text = "Limpar Histórico";
            this.BtnLimparHistorico.UseVisualStyleBackColor = true;
            this.BtnLimparHistorico.Click += new System.EventHandler(this.BtnLimparHistorico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Histórico";
            // 
            // JanelaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimparHistorico);
            this.Controls.Add(this.HistoricoTextBox);
            this.Controls.Add(this.BtnPorcentagem);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.BtnLimparMemo);
            this.Controls.Add(this.BtnIgual);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.BtnSeno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnSubtrair);
            this.Controls.Add(this.BtnSomar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "JanelaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Avançada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Button BtnSubtrair;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnSeno;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnLimparMemo;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button BtnPorcentagem;
        private System.Windows.Forms.RichTextBox HistoricoTextBox;
        private System.Windows.Forms.Button BtnLimparHistorico;
        private System.Windows.Forms.Label label1;
    }
}