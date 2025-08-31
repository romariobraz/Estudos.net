using Operacoes.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.Encodings.Web;
using System.Text.Json;


namespace Janela.MainWindow
{
    public partial class JanelaCalculadora : Form
    {
        #region Variaveis e inicializadores

        //Primeiro vou criar todas as variaveis que preciso.
        Formulas f = new Formulas();
        public double memoria1 = 0;
        public double memoria2 = 0;
        public double resultado = 0;
        public string operacao = "";
        public bool novoNumero = true;

        //inicializados
        private List<string> historico = new List<string>();
        private string caminhoArquivo = "historico_calculadora.json";


        public JanelaCalculadora()
        {
            InitializeComponent();
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                historico = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
            }
            else
            {
                historico = new List<string>();
            }
            //Para o meu histórico
            if (historico.Any()) // Se tiver histórico
            {
                HistoricoTextBox.Lines = historico.ToArray(); // Converte a lista em array de linhas
            }
        }
        #endregion

        #region Classe que configura o teclado numerico
        //Essa é uma classe conjunta, para os botões dos numeros
        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Se for o começo de um novo calculo, substitui o TextBox
            if (novoNumero)
            {
                TextBox1.Text = Convert.ToString(btn.Tag);
                novoNumero = false; // marca que já começou a digitar
            }
            else
            {
                TextBox1.Text += btn.Tag; // adiciona ao número existente
                //Observe que pego os valores pela tag do botão, não pelo texto dele.
            }
        }
        #endregion

        #region Validador, e manipular o textbox
        //Para as funções com 2 variaveis
        private void BtnOperacaoBinaria_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!double.TryParse(TextBox1.Text, out memoria1))
            {
                MessageBox.Show("Número inválido!");
                return;
            }

            operacao = btn.Tag.ToString();
            if (operacao == "%")
            {
                TextBox1.Text = $"{memoria1} {operacao} ";
                return;
            }

            operacao = Convert.ToString(btn.Tag); // "+", "-", "*", "/"
            TextBox1.Text = $"{memoria1} {operacao} ";
        }
       

        //Para as funções com apenas 1 variavel
        private void BtnOperacaoUnaria_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!double.TryParse(TextBox1.Text, out memoria1))
            {
                MessageBox.Show("Número inválido!");
                return;
            }

            operacao = btn.Tag.ToString(); // Tag = "seno", "cosseno", "tangente", "raiz"
            TextBox1.Text = $"{operacao}({memoria1})";
        }
        #endregion

        #region botão =
        //O botão igual é uma peça chave, pois ele dispara o inicio real das funções
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = 0;

                // Operações com apenas uma variavel
                switch (operacao)
                {
                    //A minha lógica base é:
                    case "seno": //Meu caso
                        resultado = f.Seno(memoria1); //Capturo o resultado da função
                        TextBox1.Text = $"Seno({memoria1}) = {resultado}";
                        //Escrevo no meu textbox.
                        break;
                        /*Isso basicamente vai se repetir em todas as funções.
                         oque vai mudar mais é o texto do textbox*/

                    case "cosseno":
                        resultado = f.Cosseno(memoria1);
                        TextBox1.Text = $"Cosseno({memoria1}) = {resultado}";
                        break;

                    case "tangente":
                        resultado = f.Tangente(memoria1);
                        TextBox1.Text = $"Tangente({memoria1}) = {resultado}";
                        break;

                    case "Raiz":
                        resultado = f.RaizQ(memoria1);
                        TextBox1.Text = $"Raiz({memoria1}) = {resultado}";
                        break;

                    case "Fibonacci":
                        int n = (int)memoria1;
                        var seq = f.Fibonacci(n);
                        TextBox1.Text = $"Fibonacci({n}) = {string.Join(", ", seq)}";
                        break;

                    case "Raio":
                        resultado = f.Raio(memoria1);
                        TextBox1.Text = $"Raio do círculo (área={memoria1}) = {resultado:F2}";
                        break;

                    case "Quadrado":
                        resultado = f.AreaQuadrado(memoria1);
                        TextBox1.Text = $"Área do Quadrado (Lado:{memoria1}) = {resultado}";
                        break;

                    case "Circulo":
                        resultado = f.AreaCirculo(memoria1);
                        TextBox1.Text = $"Área do Circulo:(Raio:{memoria1}) = {resultado}";
                        break;

                    case "CF":
                        resultado = f.CF(memoria1);
                        TextBox1.Text = $"{memoria1} Celsius = {resultado} Fahrenheit";
                        break;

                    case "CK":
                        resultado = f.CK(memoria1);
                        TextBox1.Text = $"{memoria1} Celsius = {resultado} Kelvin";
                        break;

                    case "KF":
                        resultado = f.KF(memoria1);
                        TextBox1.Text = $"{memoria1} Kelvin = {resultado} Fahrenheit";
                        break;

                    case "KC":
                        resultado = f.KC(memoria1);
                        TextBox1.Text = $"{memoria1} Kelvin  = {resultado} Celsius";
                        break;

                    case "FC":
                        resultado = f.FC(memoria1);
                        TextBox1.Text = $"{memoria1} Fahrenheit = {resultado} Celsius";
                        break;

                    case "FK":
                        resultado = f.FK(memoria1);
                        TextBox1.Text = $"{memoria1} Fahrenheit  = {resultado} Kelvin";
                        break;
                    //Só por precaução
                    default:
                        string[] partes = TextBox1.Text.Split(' ');

                        // Verifica se há operador e segundo número
                        if (partes.Length < 3)
                        {
                         MessageBox.Show("Digite a operação completa!");
                         return;
                        }

                        if (!double.TryParse(partes[2], out memoria2))
                        {
                            MessageBox.Show("Número inválido!");
                            return;
                        }

                        //Agora vamos para as operações que envolvem duas variaveis.
                        switch (operacao)
                        {
                            case "+":
                                resultado = f.Somar(memoria1, memoria2);
                                break;

                            case "-":
                                resultado = f.Subtrair(memoria1, memoria2);
                                break;

                            case "*":
                                resultado = f.Multiplicar(memoria1, memoria2);
                                break;

                            case "/":
                                if (memoria2 == 0)
                                {
                                    MessageBox.Show("Divisão por zero não é permitida!");
                                    return;
                                }
                                resultado = f.Dividir(memoria1, memoria2);
                                break;
                            case "%":
                                resultado = f.Porcentagem(memoria1, memoria2);
                                break;

                            case "Resto":
                                if (memoria2 == 0)
                                {
                                    MessageBox.Show("Operação por zero não é permitida!");
                                    return;
                                }
                                resultado = f.Resto(memoria1, memoria2);
                                break;

                            case "^":
                                resultado = f.Potencia(memoria1, memoria2);
                                break;

                            case "IMC":
                                resultado = f.Imc(memoria1, memoria2).valor; // pega apenas o valor
                                string classificacao = f.Imc(memoria1, memoria2).classificacao;
                                TextBox1.Text = $"IMC = {resultado} ({classificacao})";
                                break;

                            case "Retangulo":
                                resultado = f.AreaRetangulo(memoria1, memoria2);
                                TextBox1.Text = $"Area do Retangulo (Base{memoria1}, Altura{memoria2}) = {resultado}";
                                break;

                            default:
                                MessageBox.Show("Operação desconhecida!");
                                return;

                        }
                        //Por fim, vamos escrever o resultado
                        TextBox1.Text = $"{memoria1} {operacao} {memoria2} = {resultado}";


                        //Agora vamos serializar este resultado em um .json
                        //como sera escrito
                        string expressao = $"{memoria1} {operacao} {memoria2} = {resultado}";
                        historico.Add(expressao);

                        //Vou atualizar meu histórico
                        HistoricoTextBox.Lines = historico.ToArray();

                        //Vamos criar um encoder, para que meu json reconheça simbolos como +,-,%,/
                        string json = JsonSerializer.Serialize(
                            historico,
                            new JsonSerializerOptions
                            {
                                WriteIndented = true,
                                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                            }
                        );

                        File.WriteAllText(caminhoArquivo, json);

                        break;
                }

                // Atualiza memória para permitir operações consecutivas
                memoria1 = resultado;
                novoNumero = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        #endregion

        #region Botão que limpa, validador, e backspace
        //Botão que limpa todo meu processo
        private void BtnLimparMemo_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            memoria1 = 0;
            memoria2 = 0;
            resultado = 0;
            operacao = "";
            novoNumero = true;
        }


        //Impedir o usuário de inserir texto e dar pau em tudo
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Permitir Backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            // Permitir um único ponto ou vírgula
            if ((e.KeyChar == '.' || e.KeyChar == ',') && !txt.Text.Contains('.') && !txt.Text.Contains(','))
            {
                e.Handled = false;
                return;
            }

            // Permitir sinal negativo apenas no início
            if (e.KeyChar == '-' && txt.SelectionStart == 0 && !txt.Text.Contains("-"))
            {
                e.Handled = false;
                return;
            }

            // Permitir apenas dígitos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // Bloquear todo o resto
            e.Handled = true;
        }

        //Botão backspace
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text))
            {
                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1);
            }
        }
        #endregion

        private void BtnLimparHistorico_Click(object sender, EventArgs e)
        {
            // Limpa a lista na memória
            historico.Clear();

            // Limpa o meu textbox
            HistoricoTextBox.Clear();

            // Esvazia meu json
            string json = JsonSerializer.Serialize(
                historico,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                }
            );

            File.WriteAllText(caminhoArquivo, json);
        }

    }
}
