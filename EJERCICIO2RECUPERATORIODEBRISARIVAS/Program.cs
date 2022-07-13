using System;

namespace EJERCICIO2RECUPERATORIODEBRISARIVAS
	{

		static void Main(string[] args)
		{
			double ax;
			double bx;
			double cx;
			double dy;
			Console.Write("ingrese el valor de Ax2:");
			ax = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el valor de Bx2:");
			bx = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el valor de Cx :");
			cx = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el valor de Dy:");
			dy = Double.Parse(Console.ReadLine());
			if (Math.Pow(ax, 2) != 0 && Math.Pow(bx, 2) == 0)
			{
				Console.WriteLine("es una parabola");
			}
			if (Math.Pow(ax, 2) == 0 && Math.Pow(bx, 2) != 0)
			{
				Console.WriteLine("es una parabola");
			}
			if (Math.Pow(ax, 2) > 0 && Math.Pow(bx, 2) > 0)
			{
				if (Math.Pow(ax, 2) != Math.Pow(bx, 2))
				{
					Console.WriteLine("es una elipse");
				}
			}
			if (Math.Pow(ax, 2) < 0 && Math.Pow(bx, 2) < 0)
			{
				if (Math.Pow(bx, 2) != Math.Pow(ax, 2))
				{
					Console.WriteLine("es una elipse");
				}
			}
			if (Math.Pow(ax, 2) != 0 && Math.Pow(bx, 2) != 0)
			{
				if (Math.Pow(ax, 2) < 0 && Math.Pow(bx, 2) > 0)
				{
					if (Math.Pow(ax, 2) != Math.Pow(bx, 2))
					{
						Console.WriteLine("es una hiperbola");
					}
				}
			}
			if (Math.Pow(ax, 2) != 0 && Math.Pow(bx, 2) != 0)
			{
				if (Math.Pow(ax, 2) > 0 && Math.Pow(bx, 2) < 0)
				{
					if (Math.Pow(ax, 2) != Math.Pow(bx, 2))
					{
						Console.WriteLine("es una hiperbola");
					}
				}
			}
		}

	}

}

