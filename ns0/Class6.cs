﻿namespace ns0
{
    using System;

    internal class Class6 : Class0
    {
        private bool bool_3;
        private bool bool_4;

        internal Class6(Class47 A_1) : base(A_1)
        {
        }

        internal override void QQSV()
        {
            this.bool_3 = base.class47_0.class10_0.method_0();
            this.bool_4 = base.class47_0.class8_0.method_0();
            base.int_2 = base.method_6(this.bool_3) + base.method_6(this.bool_4);
        }

        internal override void QQSW(Class48 data)
        {
            bool flag = base.class47_0.class10_0.method_0();
            bool flag2 = base.class47_0.class8_0.method_0();
            for (int i = 0; i < base.int_0; i++)
            {
                Class694 class2 = new Class694 {
                    int_0 = data.method_12(flag),
                    int_1 = data.method_12(flag2)
                };
                base.arrayList_0.Add(class2);
            }
        }

        internal override Enum0 QQSU
        {
            get
            {
                return Enum0.const_21;
            }
        }

        internal class Class694
        {
            internal int int_0;
            internal int int_1;
        }
    }
}

