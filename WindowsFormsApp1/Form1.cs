using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * #4 => შექმენით კვადრატის კლასი, რომელიც შეიცავს ღია ცვლადს: კვადრატის გვერდის
ზომას; პრივატულ ცვლადს: კვადრატის ფართობს; ღია მეთოდებს: პირველი
მეთოდი ღია ცვლადს მნიშვნელობას ანიჭებს; მეორე მეთოდს გამოაქვს ღია
ცვლადის მნიშვნელობა; მესამე მეთოდი გამოთვლის და აბრუნებს კვადრატის
ფართობს. მთავარ პროგრამაში ნაგულისხმევი კონსტრუქტორის გამოყენებით
შექმენით შესაბამისი ობიექტი და გამოიძახეთ სამივე მეთოდი. მონაცემების
შესატანად გამოიყენეთ TextBox ვიზუალური ელემენტი, გამოსატანად კი Label
ვიზუალურ ელემენტი.

#5 => შექმენით სტუდენტის კლასი, რომელიც შეიცავს პრივატულ ცვლადებს: გვარი,
სახელი და ასაკი; ღია მეთოდებს: პირველი მეთოდი პრივატულ ცვლადებს
მნიშვნელობებს ანიჭებს; მეორე მეთოდს ეკრანზე გამოაქვს პრივატული
ცვლადების მნიშვნელობები. მთავარ პროგრამაში ნაგულისხმევი
კონსტრუქტორის გამოყენებით შექმენით შესაბამისი ობიექტი და გამოიძახეთ
ორივე მეთოდი. მონაცემების შესატანად გამოიყენეთ TextBox ვიზუალური
ელემენტი, გამოსატანად კი Label ვიზუალურ ელემენტი
 

#6 => შექმენით სტუდენტის კლასი, რომელიც შეიცავს პრივატულ ცვლადებს: გვარი,
სახელი და ასაკი; პრივატულ მეთოდს, რომელიც პრივატულ ცვლადებს
მნიშვნელობებს ანიჭებს; ღია მეთოდებს: პირველი მეთოდი იძახებს პრივატულ
მეთოდს და გადასცემს მნიშვნელობებს პრივატული ცვლადებისათვის
მისანიჭებლად; მეორე მეთოდს გამოაქვს პრივატული ცვლადების
მნიშვნელობები. მთავარ პროგრამაში ნაგულისხმევი კონსტრუქტორის
გამოყენებით შექმენით შესაბამისი ობიექტი და გამოიძახეთ ორივე მეთოდი.
მონაცემების შესატანად გამოიყენეთ TextBox ვიზუალური ელემენტი,
გამოსატანად კი Label ვიზუალურ ელემენტი
 */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // დავალება #4 ********************************************
        private void button1_Click(object sender, EventArgs e)
        {
            //შევქმნათ ობიექტი
            Kvadrati obieqti = new Kvadrati();
            //მივანიჭოთ კვადრატის გვერდს ზომა
            obieqti.MinichebaSetter(int.Parse(textBox1.Text));
            //შევქმნათ ცვლადი და მივანიჭოთ დაბრუნებული კვადრატის გვერდის ზომა
            int kvadratisGverdi = obieqti.GamotanaGetter();
            //გამოვიტანოთ ფართობი ფორმაში
            label2.Text = kvadratisGverdi.ToString();
        }
        // დავალება #4 ********************************************

        // დავალება #5 ********************************************
        private void button2_Click(object sender, EventArgs e)
        {
            Student obieqti = new Student();

            string saxeli = textBox2.Text;
            string gvari = textBox3.Text;
            int asaki = int.Parse(textBox4.Text);

            obieqti.Minicheba(gvari, saxeli, asaki);

            string gamotaniliTexti = obieqti.Gamotana();
            
            label3.Text = gamotaniliTexti.ToString();
        }
        // დავალება #5 ********************************************
        
        
        // დავალება #6 ********************************************
        private void button3_Click(object sender, EventArgs e)
        {
            Student obieqti = new Student();
            string saxeli = textBox5.Text;
            string gvari = textBox6.Text;
            int asaki = int.Parse(textBox7.Text);

            obieqti.GamodzaxebaMinicheba(gvari, saxeli, asaki);
            string gamotana = obieqti.Gamotana();
            label4.Text = gamotana.ToString();

        }
        // დავალება #6 ********************************************
    }
}
