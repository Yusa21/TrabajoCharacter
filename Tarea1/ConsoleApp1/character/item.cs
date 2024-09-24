using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic;
namespace character;

interface Item
{
  public void Apply(Character character);
}