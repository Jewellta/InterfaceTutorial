using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial
{
	interface IBarkAble
	{
		string Bark();
		string GetName();
		void SetName(string name);
	}
}
