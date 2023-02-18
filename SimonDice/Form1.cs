using System.Media;
using System.Reflection;

namespace SimonDice
{
    public partial class Form1 : Form

    {
        List <int> _simonDice = new List<int>();
        List <int> _simonDiceSeleccion = new List<int>();
        Random _random = new Random();
        int _indiceActual = 0;
        SoundPlayer _player = new SoundPlayer();
        int _puntaje = 0;
        public Form1()
        {
            InitializeComponent();
            timerDisplay.Interval = 500;
            lblPuntaje.Text = string.Empty;
        }


        private void AgregarNuevo()
        {
            AgregarNuevoValor();
            timerDisplay.Start();
        }
        private void AgregarNuevoValor()
        {
            _simonDice.Add(GenerarNuevoValor());
        }

        private int GenerarNuevoValor()
        {
            return _random.Next(0,4);
        }

        private void timerDisplay_Tick(object sender, EventArgs e)

        {
            ResetearValoresPrevios();

            if (_indiceActual == _simonDice.Count)
            {
                timerDisplay.Stop();
            }
            else
            {

                MostrarValorSeleccionado(_simonDice[_indiceActual],false);

                _indiceActual++;
            }
        }


        private void MostrarValorSeleccionado(int valor , bool resetear)
        {

            var efectoSonido = string.Empty;
            switch (valor)
            {

                case 0:
                    btn0.BackColor = resetear? Color.Gold: Color.LightYellow;
                    efectoSonido = "simonSound1.wav";

                    break;
                case 1:
                    btn1.BackColor = resetear ? Color.Green: Color.LightGreen;
                    efectoSonido = "simonSound2.wav";
                    break;
                case 2:
                    btn2.BackColor = resetear ? Color.Blue :Color.LightBlue;
                    efectoSonido = "simonSound3.wav";
                    break;
                case 3:
                    btn3.BackColor = resetear ?Color.Red: Color.LightCoral;
                    efectoSonido = "simonSound4.wav";
                    break;

                default:

                    break;
            }

            if (!resetear)
            {
                _player.SoundLocation = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Resources\\{efectoSonido}";
                _player.Play();
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            AgregarNuevo();
        }

        private void ResetearValoresPrevios()
        {
            if (_indiceActual > 0)
            {
                MostrarValorSeleccionado(_simonDice[_indiceActual - 1], true);
            }
               
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
                return;


            var boton = ((Button)sender);

            int seleccionIndex = int.Parse(boton.Name.Substring(3, 1));
            MostrarValorSeleccionado(seleccionIndex, false);
            _simonDiceSeleccion.Add(seleccionIndex);

            if (_simonDice.Count == _simonDiceSeleccion.Count)
            {

                if (listasSonIguales())
                {

                    _simonDiceSeleccion.Clear();
                    _indiceActual = 0;
                    _puntaje++;
                    lblPuntaje.Text = _puntaje.ToString();
                    AgregarNuevo();


                }
                else
                {
                   var respuesta= MessageBox.Show(this, "Errado! quiere intentar de nuevo?", "Juego Terminado", MessageBoxButtons.YesNo);

                    if(respuesta == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            

            MostrarValorSeleccionado(seleccionIndex, false);
        }


        private  bool listasSonIguales()
        {
            for (int i = 0; i < _simonDice.Count; i++)
            {

                if (_simonDice[i] != _simonDiceSeleccion[i]) {

                    return false;
                }


            }

            return true;
        }


        private void Reset()
        {
            _simonDice.Clear();
            _simonDiceSeleccion.Clear();
            _indiceActual = 0;
            _puntaje = 0;
            lblPuntaje.Text = string.Empty;
            this.Refresh();

        }
    }
}