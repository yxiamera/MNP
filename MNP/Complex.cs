using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNP
{
    class Complex
    {
        private double re, im;
        public Complex(double __re_val, double __im_val)
        {
            re = __re_val;
            im = __im_val;
        }

        public Complex()
        {
            re = 0;
            im = 0;
        }

        public static Complex operator +(Complex c1)
        {
            return new Complex(c1.re, c1.im);
        }

        public static Complex operator -(Complex c1)
        {
            return new Complex(-c1.re, -c1.im);
        }

        //Properties

        public double real
        {
            get
            {
                return this.re;
            }
        }
        public double imag
        {
            get
            {
                return this.im;
            }
        }
        public double abs
        {
            get
            {
                return Math.Sqrt(this.re * this.re + this.im * this.im);
            }
        }
        public double arg
        {
            get
            {
                return Math.Atan2(this.im, this.re);
            }
        }


        // Definitions of non-member binary operator functions

        public static Complex operator +(Complex __z1, Complex __z2)
        {
            return new Complex(__z1.re + __z2.re, __z1.im + __z2.im);
        }

        public static Complex operator +(double __re_val1, Complex __z2)
        {
            return new Complex(__re_val1 + __z2.re, __z2.im);
        }

        public static Complex operator +(Complex __z1, double __re_val2)
        {
            return new Complex(__z1.re + __re_val2, __z1.im);
        }

        public static Complex operator -(Complex __z1, Complex __z2)
        {
            return new Complex(__z1.re - __z2.re, __z1.im - __z2.im);
        }

        public static Complex operator -(double __re_val1, Complex __z2)
        {
            return new Complex(__re_val1 - __z2.re, -__z2.im);
        }

        public static Complex operator -(Complex __z1, double __re_val2)
        {
            return new Complex(__z1.re - __re_val2, __z1.im);
        }

        public static Complex operator *(Complex __z1, Complex __z2)  // ins
        {
            return new Complex(__z1.re * __z2.re - __z1.im * __z2.im,
                           __z1.re * __z2.im + __z1.im * __z2.re);
        }

        public static Complex operator *(Complex __z1, double __re_val2)  // ins
        {
            return new Complex(__z1.re * __re_val2, __z1.im * __re_val2);
        }

        public static Complex operator *(double __re_val1, Complex __z2)
        {
            return new Complex(__z2.re * __re_val1, __z2.im * __re_val1);
        }

        public static Complex operator /(Complex __z1, Complex __z2)  //ins
        {
            double d = __z2.re * __z2.re + __z2.im * __z2.im;
            return new Complex((__z1.re * __z2.re + __z1.im * __z2.im) / d,
                           (__z1.im * __z2.re - __z1.re * __z2.im) / d);
        }

        public static Complex operator /(double __re_val1, Complex __z2)  //ins
        {
            double d = __z2.re * __z2.re + __z2.im * __z2.im;
            return new Complex(__re_val1 * __z2.re / d, -__re_val1 * __z2.im / d);
        }
        public static Complex operator /(Complex __z1, double __re_val2)
        {
            return new Complex(__z1.re / __re_val2, __z1.im / __re_val2);
        }

        public static bool operator ==(Complex __z1, Complex __z2)
        {
            if (__z1.re == __z2.re && __z1.im == __z2.im)
                return true;
            else return false;
        }

        public static bool operator !=(Complex __z1, Complex __z2)
        {
            if (__z1.re == __z2.re && __z1.im == __z2.im)
                return false;
            else return true;
        }

        public new String ToString()
        {
            return String.Format("{0}+{1}i", re, im);
        }

        public Complex Copy()
        {
            return new Complex(this.re, this.im);
        }
    }
}
