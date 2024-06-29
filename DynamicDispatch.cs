
using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.NativeAot80)]
public class DynamicDispatch
{
    public abstract class Base
    {
        public abstract int VMethod();
    }

    public interface IInterface
    {
        int IfaceMethod();
    }

    public sealed class Derived1 : Base, IInterface
    {
        public int Method() => 1;
        public override int VMethod() => Method();

        public int IfaceMethod() => Method();
    }

    public sealed class Derived2 : Base, IInterface
    {
        public int Method() => 2;
        public override int VMethod() => Method();

        public int IfaceMethod() => Method();
    }

    [Params(100)]
    public int N;

    private static int VirtualInvoke(Base b) => b.VMethod();

    private static int ConstrainedVirtual<T>(T t) where T : Base => t.VMethod();

    private static int InterfaceInvoke(IInterface i) => i.IfaceMethod();

    private static int ConstrainedInvoke<T>(T t) where T : IInterface => t.IfaceMethod();

    [Benchmark]
    public int VirtualMethod()
    {
        int count = 0;
        var d1 = new Derived1();
        var d2 = new Derived2();
        for (int i = 0; i < N; i++)
        {
            if (i % 3 == 0)
                count += VirtualInvoke(d1);
            else
                count += VirtualInvoke(d2);
        }
        return count;
    }

    [Benchmark]
    public int ConstrainedVirtual()
    {
        int count = 0;
        var d1 = new Derived1();
        var d2 = new Derived2();
        for (int i = 0; i < N; i++)
        {
            if (i % 3 == 0)
                count += ConstrainedVirtual(d1);
            else
                count += ConstrainedVirtual(d2);
        }
        return count;
    }

    [Benchmark]
    public int InterfaceMethod()
    {
        int count = 0;
        var d1 = new Derived1();
        var d2 = new Derived2();
        for (int i = 0; i < N; i++)
        {
            if (i % 3 == 0)
                count += InterfaceInvoke(d1);
            else
                count += InterfaceInvoke(d2);
        }
        return count;
    }

    [Benchmark]
    public int ConstrainedInterfaceMethod()
    {
        int count = 0;
        var d1 = new Derived1();
        var d2 = new Derived2();
        for (int i = 0; i < N; i++)
        {
            if (i % 3 == 0)
                count += ConstrainedInvoke(d1);
            else
                count += ConstrainedInvoke(d2);
        }
        return count;
    }

    [Benchmark]
    public int DirectInvoke()
    {
        int count = 0;
        var d1 = new Derived1();
        var d2 = new Derived2();
        for (int i = 0; i < N; i++)
        {
            if (i % 3 == 0)
                count += d1.Method();
            else
                count += d2.Method();
        }
        return count;
    }
}