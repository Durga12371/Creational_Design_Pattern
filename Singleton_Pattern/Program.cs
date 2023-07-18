using System;
using Singleton_Pattern;


Thread t1 = new Thread(() =>
{
    var instance=UpdateService.Instance(1);
}
);
Thread t2 = new Thread(() =>
{
    var instance = UpdateService.Instance(2);
}
);
t1.Start();
t2.Start();
t1.Join();  
t2.Join();