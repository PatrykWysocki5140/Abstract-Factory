using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;
using Abstract_Factory.Models.bots.citizen;
using Abstract_Factory.Models.Bots;
using Abstract_Factory.Models.Bots.policeman;
using Abstract_Factory.Models.Bots.robber;
using Abstract_Factory.Models.Bots.villager;

namespace Abstract_Factory.Models.Engine
{
    internal class Engine
    {

        IBotFactory? factory;

        public void CreateBot(BotsEnum bot)
        {
            /*factory = new Citizen();
            Console.WriteLine(factory.GetName());*/
            
            if (bot == BotsEnum.Citizen) Console.WriteLine(GetObject(new Citizen()));
            else if (bot == BotsEnum.Policeman) Console.WriteLine(GetObject(new Policeman()));
            else if (bot == BotsEnum.Robber) Console.WriteLine(GetObject(new Robber()));
            else if (bot == BotsEnum.Villager) Console.WriteLine(GetObject(new Villager()));
            else Console.WriteLine("Wrong type");
        }


        private object? GetObject(object obj)
        {
            factory = (IBotFactory)obj;
            StringBuilder value = new();
            value.AppendLine($"I am: {factory.GetName().GenerateName()}");
            value.AppendLine($"Feature: {factory.GetFeature().Feature()}");
            value.AppendLine($"Type: {factory.GetTyp().Type()}");
            value.AppendLine($"Weapon: {factory.GetWeapon().Item()}");
            return value;
        }

    }
}
