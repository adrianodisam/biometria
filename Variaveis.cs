using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMABIOMETRICO6SEM
{
    class Variaveis
    {
        private static String NivelAcesso,T,T2,T3,T4,T5,T6,T7,T8;
        private static int tentativas = 3;

        public static int Tentativas
        {
            get { return tentativas; }
            set { tentativas = value; }
        }
        public static String Acesso
        {
            get { return NivelAcesso; }
            set { NivelAcesso = value; }
        }

        public static String t
        {
            get { return T; }
            set { T = value; }
        }
        public static String t2
        {
            get { return T2; }
            set { T2 = value; }
        }
        public static String t3
        {
            get { return T3; }
            set { T3 = value; }
        }
        public static String t4
        {
            get { return T4; }
            set { T4 = value; }
        }
        public static String t5
        {
            get { return T5; }
            set { T5 = value; }
        }
        public static String t6
        {
            get { return T6; }
            set { T6 = value; }
        }
        public static String t7
        {
            get { return T7; }
            set { T7 = value; }
        }
        public static String t8
        {
            get { return T8; }
            set { T8 = value; }
        }
    }
}
