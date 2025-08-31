using System;
using Operacoes.Models;
using Janela.MainWindow;
using System.Windows.Forms;

internal class Program
{
    private static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new JanelaCalculadora());

    }
}