//Bai1
using System;

class Diem
{
    private double x, y;

    public Diem()
    {
        x = y = 0;
    }

    public Diem(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void Nhap()
    {
        Console.Write("Nhap x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Nhap y = ");
        y = double.Parse(Console.ReadLine());
    }

    public void HienThi()
    {
        Console.WriteLine("Thong tin diem: ({0},{1}) ", x, y);
    }

    public double KhoangCach(DiemB)
    {
        return Math.Sqrt(Math.Pow(B.x - this.x, 2) + Math.Pow(B.y - this.y, 2));
    }
}



//Bai2
class Employee
{
    private int id;
    private string name;
    private int yearOfBirth;
    private double salaryLevel;
    private double basicSalary;

    public int getId()
    {
        return id;
    }
    public string getName()
    {
        return name;
    }

    public int getyearOfBirth()
    {
        return yearOfBirth;
    }

    public double getIncome()
    {
        return salaryLevel * basicSalary;
    }

    public void display()
    {
        Console.WriteLine("Thong tin nguoi lao dong");
        Console.Write("Dinh danh: ", id, "Ten: ", name, "Nam sinh: ", yearOfBirth, "Luong co ban: ", basicSalary, "Thu nhap: ", getIncome());

    }

    public double setSalaryLevel
    {
        get
        {
            return salaryLevel;
        }
        set
        {
            salaryLevel = value;
        }
    }

    public double setBasicSalary
    {
        get
        {
            return basicSalary;
        }
        set
        {
            basicSalary = value;
        }
    }


}

//Bai3

class Stack
{
    private int top;
    private int[] s;

    public Stack()
    {
        top = -1;
        s = new int[20];
    }

    public Stack(int n)
    {
        top = -1;
        s = new int[n];
    }

    public bool isEmpty()
    {
        return top == -1;
    }

    public bool isFull()
    {
        return top == s.Length - 1;
    }

    public void Push(int x)
    {
        if (isFull())
            Console.WriteLine("Stack day");
        else
            s[++top] = x;
    }

    public int Pop()
    {
        if (isEmpty())
            throw new Exception("Stack rong");
        else
        {
            int x = s[top--];
            return x;
        }
    }

}


//Bai4

class SoPhuc
{
    private double thuc, ao;
    public SoPhuc()
    {
        thuc = 0;
        ao = 0;
    }

    public SoPhuc(double thuc, double ao)
    {
        this.thuc = thuc;
        this.ao = ao;
    }

    public SoPhuc(SoPhuc t2)
    {
        this.thuc = t2.thuc;
        this.ao = t2.ao;
    }

    public void Hien()
    {
        string kq = thuc + (ao > 0 ? "+" : "") + ao + "* i";
        Console.WriteLine(kq);
    }

    public static SoPhuc operator +(SoPhuc t1, SoPhuc t2)
    {
        SoPhuc tmp = new SoPhuc();
        tmp.thuc = t1.thuc + t2.thuc;
        tmp.ao = t1.ao + t2.ao;

        return tmp;
    }

    public SoPhuc Tong(SoPhuc t2)
    {
        SoPhuc tmp = new SoPhuc();
        tmp.thuc = this.thuc + t2.thuc;
        tmp.ao = this.ao + t2.ao;

        return tmp;
    }

    public SoPhuc Hieu(SoPhuc t2)
    {
        SoPhuc tmp = new SoPhuc();
        tmp.thuc = this.thuc - t2.thuc;
        tmp.ao = this.ao - t2.ao;

        return tmp;
    }


    static void Main(string[] args)
    {

    }
}


//Bai5
class MaTran
{
    private int sh, sc;
    private int[,] a;

    public MaTran()
    {
        sh = sc = 2;
        a = new int[sh, sc];
    }

    public MaTran(int sh, int sc)
    {
        this.sh = sh;
        this.sc = sc;
        a = new int[sh, sc];
    }

    public MaTran(MaTrant2)
    {
        this.sh = t2.sh;
        this.sc = t2.sc;
        this.a = new int[sh, sc];
        for (int i = 0; i < sh; i++)
            for (int j = 0; j < sc; j++)
                this.a[i, j] = t2.a[i, j];
    }

    public void Print()
    {
        Console.WriteLine("Cac phan tu cua ma tran la");
        for (int i = 0; i < sh; i++)
        {
            for (int j = 0; j < sc; j++)
                Console.Write("{0}\t", a[i, j]);
            Console.WriteLine();
        }
    }

    public void Nhap()
    {
        Console.Write("Nhap so hang: "); sh = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot: "); sc = int.Parse(Console.ReadLine());
        a = new int[sh, sc];
        Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
        for (int i = 0; i < sh; i++)
            for (int j = 0; j < sc; j++)
            {
                Console.Write("a[{0},{1}] = ", i, j);
                a[i, j] = int.Parse(Console.ReadLine());
            }
    }

    public MaTranTong(MaTrant2)
    {
        if (this.sh == t2.sh && this.sc == t2.sc)
        {
            MaTran t = new MaTran(this.sh, this.sc);
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                    t.a[i, j] = this.a[i, j] + t2.a[i, j];
            return t;
        }
        else return null;

    }

    public MaTranHieu(MaTrant2)
    {
        if (this.sh == t2.sh && this.sc == t2.sc)
        {
            MaTran t = new MaTran(this.sh, this.sc);
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                    t.a[i, j] = this.a[i, j] - t2.a[i, j];
            return t;
        }
        else return null;

    }

    public bool TuongThich()
    {
        if (this.sh == t2.sh && this.sc == t2.sc)
            return true;
        else return false;
    }
    
}