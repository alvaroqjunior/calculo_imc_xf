using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CalculoIMC.ViewModels
{
    public class CalculadoraViewModel : BaseViewModel
    {
        private double peso;
        public double Peso
        {
            get { return peso; }
            set
            {
                SetProperty(ref peso, value);
            }
        }

        private double altura;
        public double Altura
        {
            get { return altura; }
            set
            {
                SetProperty(ref altura, value);
            }
        }

        private double imcCalculado;
        public double ImcCalculado
        {
            get { return imcCalculado; }
            set
            {
                SetProperty(ref imcCalculado, value);
            }
        }

        public CalculadoraViewModel()
        {
            Title = "Calculadora";
            CalcularCommand = new Command(CalcularImc);
        }

        public ICommand CalcularCommand { get; }

        private void CalcularImc()
        {
            if (Peso > 0 && Altura > 0)
            {
                ImcCalculado = Peso / ((Altura / 100) * (Altura / 100));
            }
            else
            {
                ImcCalculado = 0;
            }
        }
    }
}