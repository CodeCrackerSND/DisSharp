﻿namespace ns0
{
    using System;
    using System.Collections;

    internal class Class901
    {
        internal ArrayList arrayList_0;
        internal bool bool_0;
        internal bool bool_1;
        private static Class1057 class1057_0 = new Class1057();
        internal Class398 class398_0;
        internal Enum58 enum58_0;
        internal int int_0;
        internal int int_1;
        internal int int_2;
        internal int int_3;
        private static int int_4 = 1;
        private static int int_5;
        internal uint uint_0;
        internal ushort ushort_0;
        internal ushort ushort_1;

        internal Class901(Enum58 A_1)
        {
            this.enum58_0 = A_1;
            this.int_0 = -1;
            this.int_1 = -1;
        }

        internal Class901(int A_1, int A_2)
        {
            this.enum58_0 = Enum58.const_0;
            this.int_0 = A_1;
            this.int_1 = A_2;
        }

        internal Class901(Enum58 A_1, int A_2, int A_3)
        {
            this.enum58_0 = A_1;
            this.int_0 = A_2;
            this.int_1 = A_3;
        }

        internal void method_0(Class901 A_1)
        {
            this.method_2(A_1, true);
        }

        internal void method_1(Class901 A_1, bool A_2)
        {
            this.method_2(A_1, A_2);
        }

        internal void method_2(Class901 A_1, bool A_2)
        {
            int num = A_1.int_0;
            int num2 = A_1.int_1;
            if ((num >= this.int_0) && (num2 <= this.int_1))
            {
                if (this.arrayList_0 == null)
                {
                    this.arrayList_0 = new ArrayList();
                    if (num > this.int_0)
                    {
                        this.arrayList_0.Add(new Class901(this.int_0, num - 1));
                    }
                    this.arrayList_0.Add(A_1);
                    if (num2 < this.int_1)
                    {
                        this.arrayList_0.Add(new Class901(num2 + 1, this.int_1));
                    }
                    if (A_2)
                    {
                        int_5 = int_4;
                    }
                }
                else
                {
                    Class901 class2;
                    int index = 0;
                    int num4 = 0;
                    bool flag = true;
                    bool flag2 = false;
                    bool flag3 = false;
                    bool flag4 = false;
                    for (int i = 0; i < this.arrayList_0.Count; i++)
                    {
                        class2 = this.arrayList_0[i] as Class901;
                        if ((flag && (class2.int_0 <= num)) && (num <= class2.int_1))
                        {
                            index = i;
                            flag = false;
                            flag3 = class2.int_0 == num;
                        }
                        if (num2 < class2.int_0)
                        {
                            num4 = i - 1;
                            flag2 = true;
                            flag4 = class2.int_0 == (num2 + 1);
                            break;
                        }
                    }
                    if (!flag2)
                    {
                        num4 = this.arrayList_0.Count - 1;
                        flag4 = this.int_1 == num2;
                    }
                    if (index == num4)
                    {
                        if (!flag3 || !flag4)
                        {
                            if (A_2 && (this.enum58_0 != Enum58.const_0))
                            {
                                int_4++;
                                (this.arrayList_0[index] as Class901).method_2(A_1, true);
                                int_4--;
                            }
                            else if (int_4 != int_5)
                            {
                                int_4++;
                                (this.arrayList_0[index] as Class901).method_2(A_1, false);
                                int_4--;
                            }
                            else
                            {
                                class2 = this.arrayList_0[index] as Class901;
                                this.arrayList_0.RemoveAt(index);
                                if (num > class2.int_0)
                                {
                                    this.arrayList_0.Add(new Class901(class2.int_0, num - 1));
                                }
                                this.arrayList_0.Add(A_1);
                                if (num2 < class2.int_1)
                                {
                                    this.arrayList_0.Add(new Class901(num2 + 1, class2.int_1));
                                }
                                class1057_0.method_1(this.arrayList_0);
                            }
                        }
                        else
                        {
                            this.arrayList_0[index] = A_1;
                            if (A_2)
                            {
                                int_5 = int_4;
                            }
                        }
                    }
                    else
                    {
                        if (A_1.arrayList_0 == null)
                        {
                            A_1.arrayList_0 = new ArrayList();
                        }
                        if (!flag3)
                        {
                            class2 = this.arrayList_0[index] as Class901;
                            A_1.arrayList_0.Add(new Class901(num, class2.int_1));
                            class2.int_1 = num - 1;
                            index++;
                        }
                        if (!flag4)
                        {
                            class2 = this.arrayList_0[num4] as Class901;
                            A_1.arrayList_0.Add(new Class901(class2.int_0, num2));
                            class2.int_0 = num2 + 1;
                            num4--;
                        }
                        if (index < num4)
                        {
                            for (int j = index; j <= num4; j++)
                            {
                                A_1.arrayList_0.Add(this.arrayList_0[j]);
                            }
                            for (int k = 0; k <= (num4 - index); k++)
                            {
                                this.arrayList_0.RemoveAt(index);
                            }
                        }
                        this.arrayList_0.Add(A_1);
                        if (A_2)
                        {
                            int_5 = int_4;
                        }
                        class1057_0.method_1(this.arrayList_0);
                        class1057_0.method_1(A_1.arrayList_0);
                    }
                }
            }
        }
    }
}

