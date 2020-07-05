using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Необходимо для работы с файлами 
using System.IO;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] KEYinfo = null; //масcив для информации из файла-ключа
        string des = null;  //строка для дешифрованного сообщения 
        string cipher = null;  //строка для шифрованного сообщения 
       
       



        private void StartButton_Click(object sender, EventArgs e) // При нажатии кнопки "Начать Работу"
        {

            try // для выявления ошибки при выборе режима работы
            {

                //Чистка рабочей области 
                richTextBoxDES.Clear();
                richTextBoxSH.Clear();
                richTextBoxI.Clear();

                //ни один режим не выбран
                if (checkBoxSH.Checked == false && checkBoxDES.Checked == false)
                {
                    //подписи
                    labelIT.Visible = false;
                    labelSHT.Visible = false;
                    labelDEST.Visible = false;

                    //поля для текста
                    richTextBoxI.Visible = false;
                    richTextBoxSH.Visible = false;
                    richTextBoxDES.Visible = false;

                    //кнопки
                    buttonsh.Visible = false;
                    buttondes.Visible = false;
                    buttonSaveSH.Visible = false;
                    buttonSaveDES.Visible = false;
                    buttonText.Visible = false;
                    buttonKEY.Visible = false;

                    throw new ApplicationException("Выберите режим работы!");

                }

                //выбрано два режима работы

                if (checkBoxSH.Checked == true && checkBoxDES.Checked == true)
                {
                    //подписи
                    labelIT.Visible = false;
                    labelSHT.Visible = false;
                    labelDEST.Visible = false;

                    //поля для текста
                    richTextBoxI.Visible = false;
                    richTextBoxSH.Visible = false;
                    richTextBoxDES.Visible = false;

                    //кнопки
                    buttonsh.Visible = false;
                    buttondes.Visible = false;
                    buttonSaveSH.Visible = false;
                    buttonSaveDES.Visible = false;
                    buttonText.Visible = false;
                    buttonKEY.Visible = false;
                    throw new ApplicationException("Выберите только один режим работы!");
                }


                if (checkBoxSH.Checked == true) // Шифрование
                {
                    //подписи
                    labelIT.Visible = true;
                    labelSHT.Visible = true;
                    labelDEST.Visible = false;

                    //поля для текста
                    richTextBoxI.Visible = true;
                    richTextBoxSH.Visible = true;
                    richTextBoxDES.Visible = false;

                    //кнопки
                    buttonsh.Visible = true;
                    buttondes.Visible = false;
                    buttonSaveSH.Visible = false;
                    buttonSaveDES.Visible = false;
                    buttonText.Visible = true;
                    buttonKEY.Visible = true;


                }
                if (checkBoxDES.Checked == true) // Дешифровка
                {

                    //подписи
                    labelIT.Visible = false;
                    labelSHT.Visible = true;
                    labelDEST.Visible = true;

                    //поля для текста
                    richTextBoxI.Visible = false;
                    richTextBoxSH.Visible = true;
                    richTextBoxDES.Visible = true;

                    //кнопки
                    buttonsh.Visible = false;
                    buttondes.Visible = true;
                    buttonSaveSH.Visible = false;
                    buttonSaveDES.Visible = false;
                    buttonText.Visible = true;
                    buttonKEY.Visible = true;

                }

            }

            catch (ApplicationException mes) //вывод сообщения в случаи ошибки
            {
                MessageBox.Show(mes.Message);
            }
            //кнопки сохранить результат появляются позже

        }


        private void buttonKEY_Click(object sender, EventArgs e) //выбор файла - ключа
        {
            try
            {
                string KEY = null; //строка, считанная из файла - ключ
                KEY = GetInfo(); //получение информации 
                while (KEY.Length == 1 && KEY.Equals("0")) //пока файл не будет выбран, будет запрашивать его 
                {
                    MessageBox.Show("Файл не выбран");
                    KEY = GetInfo();

                }
                if (KEY.Length == 1)
                {
                    throw new Exception("Ключ состоит из одного символа. Кодирование неустойчиво!");

                }
                if (KEY.Equals("")) //проверка, что файл не пустой 
                {
                    throw new Exception("В файле - ключ нет информации!");
                }
                else
                {
                    KEYinfo = KEY.ToCharArray();
                    MessageBox.Show("Файл - ключ выбран");

                }

            }

            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }

        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            try
            {
                String INFO = null; //строка, считанная из файла 
                INFO = GetInfo();
                while (INFO.Length == 1 && INFO.Equals("0")) //пока файл не будет выбран, будет запрашивать его 
                {
                    MessageBox.Show("Файл не выбран");
                    INFO = GetInfo();
               
                }
                if (INFO.Length == 1)
                {
                    throw new Exception("Файл состоит из одного символа");

                }
                if (INFO.Length==1)
                {
                    throw new Exception("Файл состоит из одного символа");

                }

                if (INFO.Equals("")) //Проверка, что файл не пустой 
                {
                    throw new Exception("В файле нет информации!");
                }
                else
                {
                    if (checkBoxSH.Checked == true) //вывод информации на экран при режиме работы  - шифрования 
                    {
                        richTextBoxI.Clear();
                        richTextBoxI.AppendText(INFO);

                    }
                    else if (checkBoxDES.Checked == true) //вывод информации на экран при режиме работы  - дешифровка
                    {
                        richTextBoxSH.Clear();
                        richTextBoxSH.AppendText(INFO);
                    }
                }

            }

            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }

        }


        String GetInfo()//считывание информации из файла
        {
            var fileContent = string.Empty;
            string filename = null;
            //выбор файла-ключа
            OpenFileDialog OPF = new OpenFileDialog();

            OPF.InitialDirectory = "c:\\";
            OPF.Filter = "txt files (*.txt)|*.txt";
            OPF.FilterIndex = 1; // выбор только одного вида файла
            OPF.RestoreDirectory = true;

            //int flag = 1; //флаг для проверки, что файл выбран 

                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    filename = OPF.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = OPF.OpenFile();

                    StreamReader reader = new StreamReader(fileStream);
                    {
                        fileContent = reader.ReadToEnd();

                    }
                    reader.Close();

                if (fileContent == null)
                {
                    return "";
                }

                else
                {

                    return fileContent;
                }

                }
                else
                {
                    return "0";
                }
         
        }

        private void buttonsh_Click(object sender, EventArgs e) //шифрование текста 
        {
             string TEXT = null; //обнуление переменной для сообщения перед работой
            
            try
            {
                while (KEYinfo == null)
                {
                    throw new ArgumentNullException("Перед началом работы выберите файл - ключ!");

                }
                TEXT = richTextBoxI.Text;
                if (TEXT.Equals(""))
                {
                    throw new ArgumentNullException("Область для вода текста пуста. Введите информацию!");

                }
                else
                {
                    if (TEXT.Length == 1)
                    {
                        throw new Exception("В области только один символ.");
                    }
                    else
                    {
                        char[] KEY = null;
                        KEY = ChangeArray(TEXT);
                        COD(TEXT,KEY);

                    }
                }

            }
            catch (ArgumentNullException mes)
            {
                MessageBox.Show(mes.Message);
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }

        }

        public char[] ChangeArray(string text) //изменение массива данных ключа 
        {
            int n = text.Length;
            int k = KEYinfo.Length;


            if (n > k) //проверка,что массив ключа должен быть больше кодированого сообщения
            {
                int l = n / k; //только количество целых делений
                int p = n % k; //остаток от деления (сколько элементов необходимо добавить в самомо конце преобразований массива)

                char[] KEYinfoNew = new char[n]; //новый расширенный массив для значений ключа 
                int d = 0; //вспомогательная переменная для работы 
                while (l > 0)
                {
                    //Копирование данного масиива в другой в скобках, начиная с данногг индекса 
                    KEYinfo.CopyTo(KEYinfoNew, d);
                    d = d + k;
                    l--;
                }
                int b = 0;

                while (p > 0)
                {
                    KEYinfoNew[d] = KEYinfo[b];
                    d++;
                    b++;
                    p--;
                }

                return KEYinfoNew;

            }
            else
            {
                return  KEYinfo;
            }

        }

        void COD(string INFO, char[] KE) //шифрование массива 
        {
            int n = INFO.Length; //Размер массива сообщения для кодирования 
            int M = 0;
            int K = 0;
            
            byte[] Message=Encoding.GetEncoding(1251).GetBytes(INFO);  //получение кодировок для шифрования 
            byte[] KEY= Encoding.GetEncoding(1251).GetBytes(KE);
            
           int[] Result=new int[n];

            for (int i = 0; i < n; i++)
            {
                M = (int)Message[i]; //перевод кодировок таблицы сиволов в тип int
                K = (int)KEY[i];
                Result[i] = (M ^ K); //Исключающее ИЛИ работает только в типом int 

            }

            cipher = string.Join(" ", Result);
            richTextBoxSH.AppendText(cipher);
            buttonSaveSH.Visible = true;

        }

        private void buttonSaveSH_Click(object sender, EventArgs e)
        {
            SaveInfo(cipher);  //передача инфа для записи 
            cipher = null;
        
        }

        void SaveInfo(string TEXT)  //сохранение информации
        {
            var filename = string.Empty;
            //сохранение информации
            SaveFileDialog Savefile = new SaveFileDialog();

            Savefile.Filter = "txt files (*.txt)|*.txt";
            Savefile.FilterIndex = 1; // выбор только одного вида файла
            Savefile.RestoreDirectory = true;

            if (Savefile.ShowDialog() == DialogResult.OK)
            {
                filename = Savefile.FileName;

                // Запись в файл:
                StreamWriter SW_ = new StreamWriter(filename);
                {
                    SW_.WriteLine(TEXT);

                }
                SW_.Close();
            }
        }

        private void buttondes_Click(object sender, EventArgs e) //режим работы - дешифровка информации 
        {
            string TEXT = null; //обнуление переменной для сообщения перед работой

            try
            {
                while (KEYinfo == null)
                {
                    throw new ArgumentNullException("Перед началом работы выберите файл - ключ!");

                }
                TEXT = richTextBoxSH.Text;
                if (TEXT.Equals(""))
                {
                    throw new ArgumentNullException("Область для вода текста пуста. Введите информацию!");

                }
                else
                {
                    if (TEXT.Length == 1)
                    {
                        throw new Exception("В области только один символ.");
                    }
                    else
                    {
                        char[] KEY = null;
                        KEY = ChangeArray(TEXT);
                        DES(TEXT, KEY);

                    }
                }

            }
            catch (ArgumentNullException mes)
            {
                MessageBox.Show(mes.Message);
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
 
        }

        void DES(string INFO, char[] KE) //дешифровка. Каждая цифра это элемент  тут нужно будет считывать из по значениям и потом 
        {

            //на вход полуаем набор цифр
            //делим большую строку на маленькие по цифрам 
            string[] s = INFO.Split(' ');
            int[] l = new int[s.Length];

            //получение массива int
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = Convert.ToInt32(s[i]);
            }

            byte[] KEY = Encoding.GetEncoding(1251).GetBytes(KE);
            int K;
            int[] Result = new int[l.Length];

            for (int i = 0; i < l.Length; i++)
            {
                 //перевод кодировок таблицы сиволов в тип int
                K = (int)KEY[i];
                Result[i] = (l[i] ^ K); //Исключающее ИЛИ работает только в типом int 

            }

            byte[] b = new byte[l.Length];

            for (int i = 0; i < l.Length; i++)
            {
                b[i] = (byte)Result[i];
            }

            char[] Final = new char[l.Length];

            Final=Encoding.GetEncoding(1251).GetChars(b);


            des = new string(Final);
            richTextBoxDES.AppendText(des);
            buttonSaveDES.Visible = true;

        }

        private void buttonSaveDES_Click(object sender, EventArgs e) //сохранение результата дешифровки
        {
            SaveInfo(des);  //передача инфа для записи 
            des = null;

        }
    }
}
