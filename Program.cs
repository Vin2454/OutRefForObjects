class Program
    {
        static void Main(string[] args)
        {
            TestRef t1 = new TestRef();
            t1.FirstName = "vinay";
            t1.Something = "Foo";
            DoSomething1(t1);
            Console.WriteLine(t1.FirstName+ ":" + t1.Something);//vinay:Not just a changed t, but a completely different TestRef object

            TestRef t2 = new TestRef();
            t2.FirstName = "vinay";
            t2.Something = "Foo";
            DoSomething2(t2);
            Console.WriteLine(t2.FirstName + ":" + t2.Something);//vinay:Foo

            TestRef t3 = new TestRef();
            t3.FirstName = "vinay";
            t3.Something = "Foo";
            DoSomething3(ref t3);
            Console.WriteLine(t3.FirstName + ":" + t3.Something);//vinay:Not just a changed t, but a completely different TestRef object

            TestRef t4 = new TestRef();
            t4.FirstName = "vinay";
            t4.Something = "Foo";
            DoSomething4(ref t4);
            Console.WriteLine(t4.FirstName + ":" + t4.Something);//vijay:Not just a changed t, but a completely different TestRef object

            //TestRef t5 = new TestRef();
            //t5.FirstName = "vinay";
            //t5.Something = "Foo";
            //DoSomething5(out t5);
            //Console.WriteLine(t5.FirstName + ":" + t5.Something);
            //compile error at method DoSomething5: The out parameter 't' must be assigned to before control leaves the current method  delete;Use of unassigned out parameter 't' delete

            TestRef t6 = new TestRef();
            t6.FirstName = "vinay";
            t6.Something = "Foo";
            DoSomething6(out t6);
            Console.WriteLine(t6.FirstName + ":" + t6.Something);//vijay:Not just a changed t, but a completely different TestRef object

            Console.ReadKey();
        }
        static void DoSomething1(TestRef t)
        {
            t.Something = "Not just a changed t, but a completely different TestRef object";
        }
        static void DoSomething2(TestRef t)
        {
            t = new TestRef();
            t.FirstName = "vijay";
            t.Something = "Not just a changed t, but a completely different TestRef object";
        }
        static void DoSomething3(ref TestRef t)
        {
            t.Something = "Not just a changed t, but a completely different TestRef object";
        }
        static void DoSomething4(ref TestRef t)
        {
            t = new TestRef();
            t.FirstName = "vijay";
            t.Something = "Not just a changed t, but a completely different TestRef object";
        }
        //static void DoSomething5(out TestRef t)
        //{
        //    t.Something = "Not just a changed t, but a completely different TestRef object";
        //}
        static void DoSomething6(out TestRef t)
        {
            t = new TestRef();
            t.FirstName = "vijay";
            t.Something = "Not just a changed t, but a completely different TestRef object";
        }
    }
    public class TestRef
    {
        public string FirstName { get; set; }
        public string Something { get; set; }
    }
