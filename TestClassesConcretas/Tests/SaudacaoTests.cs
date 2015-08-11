using Microsoft.QualityTools.Testing.Fakes;
using NBehave.Spec.NUnit;
using NUnit.Framework;
using TestClassesConcretas;

namespace Tests
{
    public class DadoUmaSaudacao : SpecBase
    {


    }

    public class QuandoForDia : DadoUmaSaudacao
    {

        Saudacao saudacao;
        string msg;

        protected override void Establish_context()
        {
            base.Establish_context();

            saudacao = new Saudacao();
        }

        protected override void Because_of()
        {
            base.Because_of();
            using (ShimsContext.Create())
            {
                var dt = new System.DateTime(2015, 08, 11, 10, 00, 00);
                System.Fakes.ShimDateTime.NowGet = () => { return dt; };

                msg = saudacao.Saudar();
            }

        }

        [Test]
        public void EntaoSaudoComBomDia()
        {
            msg.ShouldEqual("Bom dia!");
        }
    }


    public class QuandoForTarde : DadoUmaSaudacao
    {

        Saudacao saudacao;
        string msg;

        protected override void Establish_context()
        {
            base.Establish_context();

            saudacao = new Saudacao();
        }

        protected override void Because_of()
        {
            base.Because_of();
            using (ShimsContext.Create())
            {
                var dt = new System.DateTime(2015, 08, 11, 13, 00, 00);
                System.Fakes.ShimDateTime.NowGet = () => { return dt; };

                msg = saudacao.Saudar();
            }

        }

        [Test]
        public void EntaoSaudoComBoaTarde()
        {
            msg.ShouldEqual("Boa tarde!");
        }
    }

    public class QuandoForNoite : DadoUmaSaudacao
    {

        Saudacao saudacao;
        string msg;

        protected override void Establish_context()
        {
            base.Establish_context();

            saudacao = new Saudacao();
        }

        protected override void Because_of()
        {
            base.Because_of();
            using (ShimsContext.Create())
            {
                var dt = new System.DateTime(2015, 08, 11, 19, 00, 00);
                System.Fakes.ShimDateTime.NowGet = () => { return dt; };

                msg = saudacao.Saudar();
            }

        }

        [Test]
        public void EntaoSaudoComBoaTarde()
        {
            msg.ShouldEqual("Boa noite!");
        }
    }
}
