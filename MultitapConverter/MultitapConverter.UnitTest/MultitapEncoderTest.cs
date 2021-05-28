using NUnit.Framework;
using MultitapConverter;

namespace MultitapConverter.UnitTest
{
    namespace TesteMensagemEscrita
    {
        public class TesteMensagem
        {
            [TestCase]
            public void Mensagem1()
            {
                MultitapEncoder encoder = new MultitapEncoder();
                string message = encoder.EncodeToMultitap("SEMPRE ACESSO O DOJOPUZZLES");
                
                Assert.AreEqual("77773367_7773302_222337777_77776660666036"+"6656667889999_9999555337777", message);
            }

            [TestCase]
            public void Alfabeto()
            {
                MultitapEncoder encoder = new MultitapEncoder();
                string message = encoder.EncodeToMultitap("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                Assert.AreEqual("2_22_2223_33_3334_44_4445_55_555"+"6_66_6667_77_777_77778_88_8889_99_999_9999", message);
            }

            [TestCase]
            public void ErroDigitos()
            {
                MultitapEncoder encoder = new MultitapEncoder();
                string message = encoder.EncodeToMultitap("SEMPRE 12321321");
                Assert.AreEqual("Não pode conter dígitos", message;
            }

            [TestCase]
            public void ErroTamanho()
            {
                MultitapEncoder encoder = new MultitapEncoder();
                string message = encoder.EncodeToMultitap("Lorem ipsum dolor sit amet, consectetur " +
                    "adipiscing elit. Nulla ac urna non diam ullamcorper porta. " +
                    "Suspendisse a ornare urna, id interdum dui. " +
                    "Cras vitae elit in diam suscipit fringilla. Pellentesque nec" +
                    " porttitor augue, ut eleifend erat. Vestibulum fusce.");
                Assert.AreEqual("Não pode ser maior que 255", message);
            }
        }
    }
}