using Microsoft.Maui.Controls;

namespace MauiAppTrilhaAprendizagem.Views
{
    public partial class TrilhaMatematicaPage : ContentPage
    {
        int estagioAtual = 1;
        int exercicioAtual = 0;

        // Exercícios do Estágio 1 (contagem)
        (string imagem, int respostaCorreta, string pergunta)[] exerciciosEstagio1 =
        {
            ("bolas.png", 3, "QUANTAS BOLAS TEM NA IMAGEM?"),
            ("carrinhos.png", 9, "QUANTOS CARRINHOS TEM NA IMAGEM?"),
            ("bonecas.png", 6, "QUANTAS BONECAS TEM NA IMAGEM?")
        };

        // Exercícios do Estágio 2 (completar quantidades)
        (string imagem, int respostaCorreta, string pergunta)[] exerciciosEstagio2 =
        {
            ("ursinhos.jpg", 5, "QUANTOS URSINHOS FALTAM PARA FORMAR O NÚMERO 5?"),
            ("baloes.jpg", 3, "QUANTOS BALÕES FALTAM PARA FORMAR O NÚMERO 3?"),
            ("flores.jpg", 7, "QUANTAS FLORES FALTAM PARA FORMAR O NÚMERO 7?")
        };

        public TrilhaMatematicaPage()
        {
            InitializeComponent();
            CarregarExercicio();
        }

        void CarregarExercicio()
        {
            var exercicio = estagioAtual == 1 ? exerciciosEstagio1[exercicioAtual] : exerciciosEstagio2[exercicioAtual];
            ExercicioImage.Source = exercicio.imagem;
            PerguntaLabel.Text = exercicio.pergunta;
            FeedbackLabel.Text = "";
            ProximoButton.IsVisible = false;
        }

        void OnRespostaClicked(object sender, EventArgs e)
        {
            var botao = sender as Button;
            int resposta = int.Parse(botao.Text);

            var exercicio = estagioAtual == 1 ? exerciciosEstagio1[exercicioAtual] : exerciciosEstagio2[exercicioAtual];

            if (resposta == exercicio.respostaCorreta)
            {
                FeedbackLabel.Text = "MUITO BEM!";
                FeedbackLabel.TextColor = Colors.Green;
                ProximoButton.IsVisible = true;
                Console.WriteLine("DEBUG: Resposta correta, botão Próximo liberado!");
            }
            else
            {
                FeedbackLabel.Text = "VAMOS TENTAR DE NOVO!";
                FeedbackLabel.TextColor = Colors.Red;
            }
        }

        void OnProximoClicked(object sender, EventArgs e)
        {
            exercicioAtual++;

            if (estagioAtual == 1 && exercicioAtual < exerciciosEstagio1.Length)
            {
                CarregarExercicio();
            }
            else if (estagioAtual == 1 && exercicioAtual >= exerciciosEstagio1.Length)
            {
                // Finalizou Estágio 1 → passa para Estágio 2
                estagioAtual = 2;
                exercicioAtual = 0;
                PerguntaLabel.Text = "Parabéns! Você concluiu o Estágio 1! Agora vamos para o Estágio 2.";
                ExercicioImage.Source = null;
                FeedbackLabel.Text = "";
                ProximoButton.IsVisible = true;
            }
            else if (estagioAtual == 2 && exercicioAtual < exerciciosEstagio2.Length)
            {
                CarregarExercicio();
            }
            else
            {
                PerguntaLabel.Text = "Parabéns! Você concluiu todos os estágios!";
                ExercicioImage.Source = null;
                FeedbackLabel.Text = "";
                ProximoButton.IsVisible = false;
            }
        }
    }
}
