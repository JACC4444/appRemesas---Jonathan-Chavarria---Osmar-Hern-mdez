using Android;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace appRemesas
{
    public class Global
    {
        /*
         * 
         * DEFINIR LAS LISTAS CON LOS VALORES
         * 
         * 
         * **/

        public static List<RemesaFamiliar> Remesas = new List<RemesaFamiliar>()
        {
            new RemesaFamiliar
            {
                Id = 1,
                Annio = 2000,
                ListMeses = new List<Meses>
                {
                    new Meses(1,decimal.Parse("19.8")),
                    new Meses(2,decimal.Parse("20.8")),
                    new Meses(3,decimal.Parse("23.4")),
                    new Meses(4,decimal.Parse("23.6")),
                    new Meses(5,decimal.Parse("24.8")),
                    new Meses(6,decimal.Parse("25.2")),
                    new Meses(7,decimal.Parse("26.3")),
                    new Meses(8,decimal.Parse("27.5")),
                    new Meses(9,decimal.Parse("29.4")),
                    new Meses(10,decimal.Parse("29.9")),
                    new Meses(11,decimal.Parse("29.5")),
                    new Meses(12,decimal.Parse("39.8")),
                },
            },

            new RemesaFamiliar
            {
                Id = 2,
                Annio = 2001,
                ListMeses = new List<Meses>
                {
                    new Meses(1,decimal.Parse("25.1")),
                    new Meses(2,decimal.Parse("24.7")),
                    new Meses(3,decimal.Parse("27.3")),
                    new Meses(4,decimal.Parse("26.2")),
                    new Meses(5,decimal.Parse("27.6")),
                    new Meses(6,decimal.Parse("25.2")),
                    new Meses(7,decimal.Parse("27.4")),
                    new Meses(8,decimal.Parse("30.4")),
                    new Meses(9,decimal.Parse("29.5")),
                    new Meses(10,decimal.Parse("30.9")),
                    new Meses(11,decimal.Parse("27.3")),
                    new Meses(12,decimal.Parse("34.1")),
                }
            },

            new RemesaFamiliar
            {
                Id = 3,
                Annio = 2002,
                ListMeses = new List<Meses>
                {
               new Meses(1,decimal.Parse("33.5")),
                    new Meses(2,decimal.Parse("31.8")),
                    new Meses(3,decimal.Parse("35.6")),
                    new Meses(4,decimal.Parse("33")),
                    new Meses(5,decimal.Parse("36.2")),
                    new Meses(6,decimal.Parse("33.2")),
                    new Meses(7,decimal.Parse("36.4")),
                    new Meses(8,decimal.Parse("38.1")),
                    new Meses(9,decimal.Parse("39.6")),
                    new Meses(10,decimal.Parse("38.1")),
                    new Meses(11,decimal.Parse("38.2")),
                    new Meses(12,decimal.Parse("45.1"))
                }
            },

            new RemesaFamiliar
            {
                Id = 4,
                Annio = 2004,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("38")),
                  new Meses(2, decimal.Parse("37.2")),
                  new Meses(3, decimal.Parse("42.3")),
                  new Meses(4, decimal.Parse("40")),
                  new Meses(5, decimal.Parse("43.4")),
                  new Meses(6, decimal.Parse("41.5")),
                  new Meses(7, decimal.Parse("43.2")),
                  new Meses(8, decimal.Parse("43")),
                  new Meses(9, decimal.Parse("48.9")),
                  new Meses(10, decimal.Parse("47.9")),
                  new Meses(11, decimal.Parse("46.1")),
                  new Meses(12, decimal.Parse("47.3"))
                }
            },

            new RemesaFamiliar
            {
                Id = 5,
                Annio = 2005,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("51.4")),
                  new Meses(2, decimal.Parse("49.5")),
                  new Meses(3, decimal.Parse("52.7")),
                  new Meses(4, decimal.Parse("48.8")),
                  new Meses(5, decimal.Parse("52.3")),
                  new Meses(6, decimal.Parse("47.8")),
                  new Meses(7, decimal.Parse("49.8")),
                  new Meses(8, decimal.Parse("48.6")),
                  new Meses(9, decimal.Parse("52.1")),
                  new Meses(10, decimal.Parse("49.5")),
                  new Meses(11, decimal.Parse("50.8")),
                  new Meses(12, decimal.Parse("62.4"))
                }
            },
            new RemesaFamiliar
            {
                Id = 6,
                Annio = 2006,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("57.8")),
                  new Meses(2, decimal.Parse("54.6")),
                  new Meses(3, decimal.Parse("61.2")),
                  new Meses(4, decimal.Parse("54.7")),
                  new Meses(5, decimal.Parse("60.2")),
                  new Meses(6, decimal.Parse("53.6")),
                  new Meses(7, decimal.Parse("57.1")),
                  new Meses(8, decimal.Parse("58.1")),
                  new Meses(9, decimal.Parse("63.4")),
                  new Meses(10, decimal.Parse("61.2")),
                  new Meses(11, decimal.Parse("52.9")),
                  new Meses(12, decimal.Parse("62.7"))
                }
            },

            new RemesaFamiliar
            {
                Id = 7,
                Annio = 2007,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("51.4")),
                  new Meses(2, decimal.Parse("52.6")),
                  new Meses(3, decimal.Parse("61.1")),
                  new Meses(4, decimal.Parse("57.3")),
                  new Meses(5, decimal.Parse("63.9")),
                  new Meses(6, decimal.Parse("59.9")),
                  new Meses(7, decimal.Parse("61.8")),
                  new Meses(8, decimal.Parse("65.2")),
                  new Meses(9, decimal.Parse("62.7")),
                  new Meses(10, decimal.Parse("66.5")),
                  new Meses(11, decimal.Parse("65.7")),
                  new Meses(12, decimal.Parse("71.5"))
                }
            },

            new RemesaFamiliar{
                Id = 8,
                Annio = 2008,
                ListMeses = new List<Meses>
                {
                  new Meses(2, decimal.Parse("63.4")),
                  new Meses(3, decimal.Parse("71.5")),
                  new Meses(4, decimal.Parse("67.7")),
                  new Meses(5, decimal.Parse("73.6")),
                  new Meses(6, decimal.Parse("66.8")),
                  new Meses(7, decimal.Parse("66.9")),
                  new Meses(8, decimal.Parse("69.5")),
                  new Meses(9, decimal.Parse("70.8")),
                  new Meses(10, decimal.Parse("67.5")),
                  new Meses(11, decimal.Parse("66.1")),
                  new Meses(12, decimal.Parse("73.5"))
                }
            },

            new RemesaFamiliar{
                Id = 9,
                Annio = 2009,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("62.7")),
                  new Meses(2, decimal.Parse("62.8")),
                  new Meses(3, decimal.Parse("70.4")),
                  new Meses(4, decimal.Parse("62.5")),
                  new Meses(5, decimal.Parse("66.2")),
                  new Meses(6, decimal.Parse("62.1")),
                  new Meses(7, decimal.Parse("61.3")),
                  new Meses(8, decimal.Parse("60.7")),
                  new Meses(9, decimal.Parse("62.2")),
                  new Meses(10, decimal.Parse("64.4")),
                  new Meses(11, decimal.Parse("61.9")),
                  new Meses(12, decimal.Parse("71.2"))
                }
            },

            new RemesaFamiliar{
                Id = 10,
                Annio = 2010,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("60.7")),
                  new Meses(2, decimal.Parse("64.1")),
                  new Meses(3, 77),
                  new Meses(4, decimal.Parse("63.8")),
                  new Meses(5, decimal.Parse("70.2")),
                  new Meses(6, decimal.Parse("63.5")),
                  new Meses(7, decimal.Parse("66.5")),
                  new Meses(8, decimal.Parse("66.5")),
                  new Meses(9, decimal.Parse("67.9")),
                  new Meses(10, decimal.Parse("70.3")),
                  new Meses(11, decimal.Parse("70.6")),
                  new Meses(12, decimal.Parse("81.7"))

                }
            },

            new RemesaFamiliar{
                Id = 11,
                Annio = 2011,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("67.4")),
                  new Meses(2, decimal.Parse("69.3")),
                  new Meses(3, decimal.Parse("77.5")),
                  new Meses(4, decimal.Parse("73.4")),
                  new Meses(5, decimal.Parse("77.8")),
                  new Meses(6, 70),
                  new Meses(7, decimal.Parse("74.5")),
                  new Meses(8, decimal.Parse("77.3")),
                  new Meses(9, decimal.Parse("74.8")),
                  new Meses(10, decimal.Parse("79.4")),
                  new Meses(11, decimal.Parse("75.7")),
                  new Meses(12, decimal.Parse("94.5"))


                }
            },

            new RemesaFamiliar{
                Id = 12,
                Annio = 2012,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("78.1")),
                  new Meses(2, decimal.Parse("82.3")),
                  new Meses(3, decimal.Parse("89.7")),
                  new Meses(4, decimal.Parse("80.1")),
                  new Meses(5, decimal.Parse("85.2")),
                  new Meses(6, decimal.Parse("78.9")),
                  new Meses(7, decimal.Parse("80.9")),
                  new Meses(8, decimal.Parse("82.4")),
                  new Meses(9, decimal.Parse("82.9")),
                  new Meses(10, decimal.Parse("87.3")),
                  new Meses(11, decimal.Parse("82.8")),
                  new Meses(12, decimal.Parse("103.6"))
                }
            },

            new RemesaFamiliar{
                Id = 13,
                Annio = 2013,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("83.4")),
                  new Meses(2, decimal.Parse("83.7")),
                  new Meses(3, decimal.Parse("90.2")),
                  new Meses(4, decimal.Parse("90.7")),
                  new Meses(5, decimal.Parse("92.7")),
                  new Meses(6, decimal.Parse("80.9")),
                  new Meses(7, decimal.Parse("86.6")),
                  new Meses(8, decimal.Parse("88.6")),
                  new Meses(9, decimal.Parse("90.5")),
                  new Meses(10, decimal.Parse("90.3")),
                  new Meses(11, decimal.Parse("89.1")),
                  new Meses(12, 111)
                }
            },

            new RemesaFamiliar{
                Id = 14,
                Annio = 2014,
                ListMeses = new List<Meses>
                {
                  new Meses(1, decimal.Parse("85.6")),
                  new Meses(2, 90),
                  new Meses(3, decimal.Parse("101.6")),
                  new Meses(4, decimal.Parse("91.1")),
                  new Meses(5, decimal.Parse("98.5")),
                  new Meses(6, decimal.Parse("88.4")),
                  new Meses(7, decimal.Parse("92.6")),
                  new Meses(8, decimal.Parse("92.2")),
                  new Meses(9, decimal.Parse("94.7")),
                  new Meses(10, decimal.Parse("93.5")),
                  new Meses(11, 91),
                  new Meses(12, decimal.Parse("116.6"))

                }
            },

        new RemesaFamiliar{
                Id = 15,
                Annio = 2015,
                ListMeses = new List<Meses>
                {
                      new Meses(1, decimal.Parse("88.9")),
                      new Meses(2, decimal.Parse("94.1")),
                      new Meses(3, decimal.Parse("106.2")),
                      new Meses(4, decimal.Parse("94.4")),
                      new Meses(5, decimal.Parse("104.9")),
                      new Meses(6, decimal.Parse("93.1")),
                      new Meses(7, decimal.Parse("97.6")),
                      new Meses(8, decimal.Parse("96.6")),
                      new Meses(9, decimal.Parse("98.7")),
                      new Meses(10, decimal.Parse("102.6")),
                      new Meses(11, decimal.Parse("95.7")),
                      new Meses(12, decimal.Parse("120.6"))


                }
            },

        new RemesaFamiliar{
                Id = 16,
                Annio = 2016,
                ListMeses = new List<Meses>
                {
                      new Meses(1, decimal.Parse("91.2")),
                      new Meses(2, decimal.Parse("103.4")),
                      new Meses(3, decimal.Parse("107.7")),
                      new Meses(4, decimal.Parse("103.5")),
                      new Meses(5, decimal.Parse("107.4")),
                      new Meses(6, decimal.Parse("95.5")),
                      new Meses(7, decimal.Parse("98.7")),
                      new Meses(8, decimal.Parse("107.9")),
                      new Meses(9, decimal.Parse("106.3")),
                      new Meses(10, decimal.Parse("108.1")),
                      new Meses(11, decimal.Parse("104.3")),
                      new Meses(12, decimal.Parse("130.1"))



                }
            },

        new RemesaFamiliar{
                Id = 17,
                Annio = 2017,
                ListMeses = new List<Meses>
                {
                      new Meses(1, decimal.Parse("102.1")),
                      new Meses(2, decimal.Parse("107.6")),
                      new Meses(3, decimal.Parse("113.6")),
                      new Meses(4, decimal.Parse("108.4")),
                      new Meses(5, decimal.Parse("121.2")),
                      new Meses(6, decimal.Parse("111.1")),
                      new Meses(7, decimal.Parse("122.4")),
                      new Meses(8, decimal.Parse("120.4")),
                      new Meses(9, decimal.Parse("112.8")),
                      new Meses(10, decimal.Parse("118.5")),
                      new Meses(11, 116),
                      new Meses(12, decimal.Parse("136.7"))

                }
            },
        };
    }


    /*
     * 
     * DEFINCION DE CLASES
     * 
     * **/

    public class RemesaFamiliar
    {
        public int Id { get; set; }
        public int Annio { get; set; }
        public List<Meses> ListMeses { get; set; }

        public decimal total
        {
            get
            {
                return ListMeses.Sum(x => x.Monto);

            }
        }

    }

    public class Meses
    {
        public int Mes { get; set; }
        public decimal Monto { get; set; }

        public Meses(int mes, decimal monto)
        {
            Mes = mes;
            Monto = monto;
        }

        public Meses()
        {

        }
    }

}