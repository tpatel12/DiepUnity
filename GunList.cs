using System;
using JetBrains.Annotations;

public static class GunList
{

    public static Gun getFirstGun()
    {

        Gun firstGun = new Gun(20, 10, 0.25f, 5, 1, 0);

        Gun a = new Gun(20, 8, 0.1f, 10, 1, 50);
        firstGun.child1 = a;

        Gun aa = new Gun(25, 4, 0.04f, 15, 1, 150);
        a.child1 = aa;

        Gun ab = new Gun(20, 15, 0.1f, 20, 2, 100);
        a.child2 = ab;



        return firstGun;


    }
}

