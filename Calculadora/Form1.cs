namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Button btnBorrarUltimo;
        private Button btnBorrarActual;
        private Button btnBorrarTodo;
        private Button btnSigno;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSuma;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnResta;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMultiplicacion;
        private Button btn0;
        private Button btnPunto;
        private Button btnIgual;
        private Button btnDivision;

        private Button btnPi;      
        private Button btnLog;
        private Button btnSqrt;
        private Button btnCuadrado;
        private Button btnSinh;
        private Button btnSin;
        private Button btnDec;
        private Button btnXy;
        private Button btnCosh;
        private Button btnCos;
        private Button btnBin;
        private Button btn1X;
        private Button btnTanh;
        private Button btnTan;
        private Button btnHex;
        private Button btnLnx;
        private Button btnExp;
        private Button btnMod;
        private Button btnOct;
        private TextBox txtDisplay;
        private Label lbLabelOperacion;
        private String operacion;
        private Double resultado;
        private MenuStrip menu;
        private ToolStripMenuItem catTipo;
        private ToolStripMenuItem miEstandar;
        private ToolStripMenuItem miCientifica;
        public Form1()
        {
            operacion = "";
            resultado = 0;
            btnBorrarUltimo = new Button(); 
            btnBorrarActual = new Button(); 
            btnBorrarTodo = new Button();
            btn7 = new Button(); 
            btn8 = new Button(); 
            btn9 = new Button(); 
            btnSuma = new Button(); 
            btn4 = new Button(); 
            btn5 = new Button(); 
            btn6 = new Button(); 
            btnResta = new Button(); 
            btn1 = new Button(); 
            btn2 = new Button(); 
            btn3 = new Button(); 
            btnMultiplicacion = new Button();
            btn0 = new Button(); 
            btnPunto = new Button(); 
            btnIgual = new Button(); 
            btnDivision = new Button();
            btnSigno = new Button();
            txtDisplay = new TextBox();
            lbLabelOperacion = new Label();
            
            btnPi  = new Button();
            btnLog = new Button();
            btnSqrt = new Button();
            btnCuadrado = new Button();
            btnSinh = new Button();
            btnSin = new Button();
            btnDec = new Button();
            btnXy = new Button();
            btnCosh = new Button();
            btnCos = new Button();
            btnBin = new Button();
            btn1X = new Button();
            btnTanh = new Button();
            btnTan = new Button();
            btnHex = new Button();
            btnLnx = new Button();
            btnExp = new Button();
            btnMod = new Button();
            btnOct = new Button();
            menu = new MenuStrip();
            catTipo = new ToolStripMenuItem();
            miEstandar= new ToolStripMenuItem(); 
            miCientifica= new ToolStripMenuItem();

            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            this.Size = new Size(600, 500);
            this.Text = "Calculadora";
            //Inicializar tamano
            btnBorrarUltimo.Size = new Size(60, 60);
            btnBorrarActual.Size = new Size(60, 60); 
            btnBorrarTodo.Size = new Size(60, 60); 
            btnSigno.Size = new Size(60, 60); 
            btn7.Size = new Size(60, 60); 
            btn8.Size = new Size(60, 60); 
            btn9.Size = new Size(60, 60); 
            btnSuma.Size = new Size(60, 60); 
            btn4.Size = new Size(60, 60); 
            btn5.Size = new Size(60, 60); 
            btn6.Size = new Size(60, 60); 
            btnResta.Size = new Size(60, 60); 
            btn1.Size = new Size(60, 60); 
            btn2.Size = new Size(60, 60); 
            btn3.Size = new Size(60, 60); 
            btnMultiplicacion.Size = new Size(60, 60); 
            btn0.Size = new Size(60, 60); 
            btnPunto.Size = new Size(60, 60); 
            btnIgual.Size = new Size(60, 60); 
            btnDivision.Size = new Size(60, 60);
            btnPi.Size = new Size(60,60);
            btnLog.Size =  new Size(60,60);
            btnSqrt.Size = new Size(60,60);
            btnCuadrado.Size = new Size(60,60);
            btnSinh.Size = new Size(60,60);
            btnSin.Size =  new Size(60,60);
            btnDec.Size =  new Size(60,60);
            btnXy.Size =  new Size(60,60);
            btnCosh.Size =  new Size(60,60);
            btnCos.Size = new Size(60,60);
            btnBin.Size =  new Size(60,60);
            btn1X.Size =  new Size(60,60);
            btnTanh.Size =  new Size(60,60);
            btnTan.Size =  new Size(60,60);
            btnHex.Size =  new Size(60,60);
            btnLnx.Size =  new Size(60,60);
            btnExp.Size =  new Size(60,60);
            btnMod.Size =  new Size(60,60);
            btnOct.Size =  new Size(60,60);
            txtDisplay.Size = new Size(558, 50);
            txtDisplay.Multiline=true;
            lbLabelOperacion.AutoSize = true;
            txtDisplay.TextAlign = HorizontalAlignment.Right;

            //Inicializar texto
            btnBorrarUltimo.Text = "⌫"; 
            btnBorrarActual.Text = "CE"; 
            btnBorrarTodo.Text = "C"; 
            btnSigno.Text = "±"; 
            btn7.Text = "7"; 
            btn8.Text = "8"; 
            btn9.Text = "9"; 
            btnSuma.Text = "+"; 
            btn4.Text = "4"; 
            btn5.Text = "5"; 
            btn6.Text = "6"; 
            btnResta.Text = "-"; 
            btn1.Text = "1"; 
            btn2.Text = "2"; 
            btn3.Text = "3"; 
            btnMultiplicacion.Text = "*"; 
            btn0.Text = "0"; 
            btnPunto.Text = "."; 
            btnIgual.Text = "="; 
            btnDivision.Text = "/";

            btnPi.Text = "π";
            btnLog.Text = "Log";
            btnSqrt.Text = "Sqrt";
            btnCuadrado.Text = "x^2";
            btnSinh.Text = "Sinh";
            btnSin.Text = "Sin";
            btnDec.Text = "Dec";
            btnXy.Text = "x^y";
            btnCosh.Text = "Cosh";
            btnCos.Text = "Cos";
            btnBin.Text = "Bin";
            btn1X.Text = "1/x";
            btnTanh.Text = "Tanh";
            btnTan.Text = "Tan";
            btnHex.Text = "Hex";
            btnLnx.Text = "Ln x";
            btnExp.Text = "Exp";
            btnMod.Text = "Mod";
            btnOct.Text = "Oct";
            catTipo.Text = "Tipo";
            miEstandar.Text = "Estandar";
            miCientifica.Text = "Cientifica";


            //Posicion
            txtDisplay.Location = new Point(10, 50);
            lbLabelOperacion.Location = new Point(10, 50);

            List<Button> lista = new List<Button>();
            lista.Add(btnBorrarUltimo); 
            lista.Add(btnBorrarActual); 
            lista.Add(btnBorrarTodo); 
            lista.Add(btnSigno); 
            lista.Add(btn7); 
            lista.Add(btn8); 
            lista.Add(btn9); 
            lista.Add(btnSuma); 
            lista.Add(btn4); 
            lista.Add(btn5); 
            lista.Add(btn6); 
            lista.Add(btnResta);
            lista.Add(btn1);
            lista.Add(btn2); 
            lista.Add(btn3); 
            lista.Add(btnMultiplicacion); 
            lista.Add(btn0); 
            lista.Add(btnPunto); 
            lista.Add(btnIgual); 
            lista.Add(btnDivision);

            int x = 10;
            int y = 105;
            int count = 0;

            foreach (Button btn in lista)
            {
                if (count == 4)
                {
                    x = 10;
                    y += 67;
                    count = 0;
                }

                btn.Click += new EventHandler(btn_click);
                btn.Location = new Point(x, y);
                this.Controls.Add(btn);
                x += 67;
                count ++;
            }

            List<Button> cientifica = new List<Button>();
            cientifica.Add(btnPi);
            cientifica.Add(btnLog);
            cientifica.Add(btnSqrt);
            cientifica.Add(btnCuadrado);
            cientifica.Add(btnSinh);
            cientifica.Add(btnSin);
            cientifica.Add(btnDec);
            cientifica.Add(btnXy);
            cientifica.Add(btnCosh);
            cientifica.Add(btnCos);
            cientifica.Add(btnBin);
            cientifica.Add(btn1X);
            cientifica.Add(btnTanh);
            cientifica.Add(btnTan);
            cientifica.Add(btnHex);
            cientifica.Add(btnLnx);
            cientifica.Add(btnExp);
            cientifica.Add(btnMod);
            cientifica.Add(btnOct);
            x = 310;
            y = 105;
            count = 0;
            foreach (Button btn in cientifica)
            {
                if (count == 4)
                {
                    x = 310;
                    y += 67;
                    count = 0;
                }
                btn.Location = new Point(x, y);
                this.Controls.Add(btn);
                x += 67;
                count ++;
            }
            
            //eventos
            miEstandar.Click += new EventHandler(menuEstandar_Click);
            miCientifica.Click += new EventHandler(menuEstandar_Cientifica);
            btnPi.Click += new EventHandler(btnPiClick);
            btnLog.Click += new EventHandler(btnLogClick);
            btnSin.Click += new EventHandler(btnSenClick);
            btnBin.Click += new EventHandler(btnBinClick);
            btnSqrt.Click += new EventHandler(btnSqrtClick);
            btnCuadrado.Click += new EventHandler(btnCuadradoClick);
            btnSinh.Click += new EventHandler(btnSinHClick);
            btnDec.Click += new EventHandler(btnDecClick);
            btnXy.Click += new EventHandler(btn_click);
            btnCosh.Click += new EventHandler(btnCoshClick);
            btnCos.Click += new EventHandler(btnCosClick);
            btn1X.Click += new EventHandler(btn1xClick);
            btnTanh.Click += new EventHandler(btnTanhClick);
            btnTan.Click += new EventHandler(btnTanClick);
            btnHex.Click += new EventHandler(btnHexClick);
            btnLnx.Click += new EventHandler(btnLnxClick);
            btnExp.Click += new EventHandler(btn_click);
            btnMod.Click += new EventHandler(btn_click);
            btnOct.Click += new EventHandler(btnOctClick);
            
            //Agregar controles al formulario
            this.Controls.Add(txtDisplay);
            this.Controls.Add(lbLabelOperacion);
            catTipo.DropDownItems.Add(miEstandar);
            catTipo.DropDownItems.Add(miCientifica);
            menu.Items.Add(catTipo);
            this.Controls.Add(menu);
            lbLabelOperacion.BringToFront();

        }
        
        private void btnOctClick(object? sender, EventArgs e)
        {
            if (lbLabelOperacion.Text.StartsWith("Bin"))
            {
                lbLabelOperacion.Text = $"Oct({txtDisplay.Text})=";
                int dec = binarioDecimal(txtDisplay.Text);
                txtDisplay.Text = decimalOctal(dec).ToString();
            }else if (lbLabelOperacion.Text.StartsWith("Hex"))
            {
                lbLabelOperacion.Text = $"Oct({txtDisplay.Text})=";
                int dec = HexadecimalDecimal(txtDisplay.Text);
                txtDisplay.Text = decimalOctal(dec).ToString();
            }else if (lbLabelOperacion.Text.StartsWith("Oct"))
            {
                
            }else 
            {
                lbLabelOperacion.Text = $"Oct({txtDisplay.Text}) =";
                txtDisplay.Text = decimalOctal( int.Parse(txtDisplay.Text) ).ToString(); 
            }
        }
        private void btnHexClick(object? sender, EventArgs e)
        {
            if (lbLabelOperacion.Text.StartsWith("Bin"))
            {
                lbLabelOperacion.Text = $"Hex({txtDisplay.Text})=";
                int dec = binarioDecimal(txtDisplay.Text);
                txtDisplay.Text = decimalHexadecimal(dec);
            }else if (lbLabelOperacion.Text.StartsWith("Oct"))
            {
                lbLabelOperacion.Text = $"Hex({txtDisplay.Text})=";
                int dec = octalDecimal(int.Parse(txtDisplay.Text));
                txtDisplay.Text = decimalHexadecimal(dec);
            }else if (lbLabelOperacion.Text.StartsWith("Hex"))
            {
                
            }else 
            {
                lbLabelOperacion.Text = $"Hex({txtDisplay.Text}) =";
                txtDisplay.Text = decimalHexadecimal(int.Parse(txtDisplay.Text)); 
            }
        }
        private void btnDecClick(object? sender, EventArgs e)
        {
            if (lbLabelOperacion.Text.StartsWith("Bin"))
            {
                lbLabelOperacion.Text = "";
                txtDisplay.Text = binarioDecimal(txtDisplay.Text).ToString();
            }else if (lbLabelOperacion.Text.StartsWith("Hex"))
            {
                lbLabelOperacion.Text = "";
                txtDisplay.Text = HexadecimalDecimal(txtDisplay.Text).ToString();
            }else if (lbLabelOperacion.Text.StartsWith("Oct"))
            {
                lbLabelOperacion.Text = "";
                txtDisplay.Text = octalDecimal(int.Parse(txtDisplay.Text)).ToString();
            }
        }
        private void btnLnxClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Ln({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Log(Double.Parse(txtDisplay.Text)).ToString(); 
        }
        private void btnTanClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Tan({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Tan(Double.Parse(txtDisplay.Text)).ToString(); 
        }
        private void btnTanhClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Tanh({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Tanh(Double.Parse(txtDisplay.Text)).ToString(); 
        }
        private void btn1xClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"1/{txtDisplay.Text} =";
            txtDisplay.Text = (1/Double.Parse(txtDisplay.Text)).ToString(); 
        }
        private void btnCosClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Cos({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Cos(Double.Parse(txtDisplay.Text)).ToString(); 
        }
        private void btnCoshClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Cosh({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Cosh(Double.Parse(txtDisplay.Text)).ToString(); 
        }
        private void btnSinHClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"SenH({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Sinh(Double.Parse(txtDisplay.Text)).ToString();
        }
        private void btnCuadradoClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"{txtDisplay.Text}^2 =";
            txtDisplay.Text = Math.Pow(Double.Parse(txtDisplay.Text),2).ToString();
        }
        private void btnSqrtClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Sqrt({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Sqrt(Double.Parse(txtDisplay.Text)).ToString();
        }
        private void btnBinClick(object? sender, EventArgs e)
        {
            if (lbLabelOperacion.Text.StartsWith("Hex"))
            {
                lbLabelOperacion.Text = $"Bin({txtDisplay.Text})=";
                int dec = HexadecimalDecimal(txtDisplay.Text);
                txtDisplay.Text = decimalBinario(dec).ToString();
            }else if (lbLabelOperacion.Text.StartsWith("Oct"))
            {
                lbLabelOperacion.Text = $"Bin({txtDisplay.Text})=";
                int dec = octalDecimal(int.Parse(txtDisplay.Text));
                txtDisplay.Text = decimalBinario(dec).ToString();
            }else if (lbLabelOperacion.Text.StartsWith("Bin"))
            {
                
            }else 
            {
                lbLabelOperacion.Text = $"Bin({txtDisplay.Text}) =";
                txtDisplay.Text = Convert.ToString(Int32.Parse(txtDisplay.Text),2); 
            }

        }
        
        private void btnSenClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Sen({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Sin(Double.Parse(txtDisplay.Text)).ToString(); 
        }
        private void btnPiClick(object? sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592";
        }

        private void btnLogClick(object? sender, EventArgs e)
        {
            lbLabelOperacion.Text = $"Log({txtDisplay.Text}) =";
            txtDisplay.Text = Math.Log10(Double.Parse(txtDisplay.Text)).ToString(); 
        }

        private void menuEstandar_Click(object? sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
            txtDisplay.Size = new Size(260, 50);
        }
        
        private void menuEstandar_Cientifica(object? sender, EventArgs e)
        {
            this.Size = new Size(600, 500);
            txtDisplay.Size = new Size(558, 50);
        }
        private void btn_click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                Button btn = (Button) sender;
                switch (btn.Text)
                {
                    case "⌫":
                        if (txtDisplay.Text.Length > 0)
                        {
                            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                        }

                        if (txtDisplay.Text == "")
                        {
                            txtDisplay.Text = "0";
                        }
                        break;
                    case "CE":
                        txtDisplay.Text = "0";
                        break;
                    case "C":
                        txtDisplay.Text = "0";
                        lbLabelOperacion.Text = "";
                        break;
                    case "=":
                        boton_igual();
                        break;
                    case "±":
                        txtDisplay.Text = (Double.Parse(txtDisplay.Text) * -1).ToString();
                        break;
                    case "0": case "1": case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9": case ".":
                        boton_numero(btn.Text);
                        break;
                    case "+": case "-": case "*": case "/" :
                        boton_operador(btn.Text);
                        break;
                    case "x^y":
                        boton_operador("^");
                        break;
                    case "Mod":
                        boton_operador(btn.Text);
                        break;
                    case "Exp":
                        boton_operador(btn.Text);
                        break;
                }
            }
        }

        private void boton_igual()
        {
            lbLabelOperacion.Text += " " + txtDisplay.Text + " =";
            switch (operacion)
            {
                case "+":
                    txtDisplay.Text = (resultado + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultado - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultado * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "^":
                    txtDisplay.Text = (Math.Pow(resultado,Double.Parse(txtDisplay.Text)) ).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (resultado % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    txtDisplay.Text = (resultado*Math.Pow(10,Double.Parse(txtDisplay.Text))).ToString();
                    break;
            }
        }

        private void boton_operador(String operador)
        {
            operacion = operador;
            resultado = Double.Parse(txtDisplay.Text);
            lbLabelOperacion.Text = txtDisplay.Text + " " + operacion;
            txtDisplay.Text = "0";
        }

        private void boton_numero(String valor)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            if (valor == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += valor;
                }
            }
            else
            {
                txtDisplay.Text += valor;
            }
        }

        private int octalDecimal(int octal)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
 
            for (long i = octal, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (!(digito >= 0 && digito <= 7))
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(8, j);
            }
 
            return numero;
        }

        private int decimalOctal(int numero)
        {
            int octal = 0;
 
            const int DIVISOR = 8;
            int digito = 0;
 
            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                octal += digito * (int)Math.Pow(10, j);
            }
            return octal;
        }

        private String decimalHexadecimal(int numero)
        {
            return Convert.ToString(numero, 16).ToUpper(); 
        }

        private int HexadecimalDecimal(String hexadecimal)
        {
            return Convert.ToInt32(hexadecimal, 16);
        }

        private int binarioDecimal(string binario)
        {
            int dec = 0; 

            for(int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    dec += (int)Math.Pow(2, i);
                }
            }
            return dec;
        }

        private int decimalBinario(int numero)
        {
            int binario = 0;
 
            const int DIVISOR = 2;
            int digito = 0;
 
            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (int)Math.Pow(10, j);
            }
            return binario;
        }
        
    }
}