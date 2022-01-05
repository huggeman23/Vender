using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Vender.Models;
using Vender.VendingMechine;


namespace Vender.Test
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData(10,5,5)]
        [InlineData(1,2,1)]
        [InlineData(1, 1, 0)]
        
        public void purches(int ins,int pur, double expect)
        {
            var vend = new Vending();
            vend.InsertMoney(ins);
            vend.Purtches(pur);
            Assert.Equal(expect, vend.sum);

        }
        [Theory]
        [InlineData(1,1)]
        [InlineData(2,0)]
        [InlineData(-10,0)]
        public void insert(int ins, double expect)
        {
            var vend = new Vending();
            vend.InsertMoney(ins);
            Assert.Equal(expect, vend.sum);

        }
        [Theory]
        [InlineData(10,1, 11)]
        [InlineData(10,2, 10)]
        [InlineData(10,-10, 10)]
        public void insertMultiple(int firstins,int ins, double expect)
        {
            var vend = new Vending();
            vend.InsertMoney(firstins);
            vend.InsertMoney(ins);
            Assert.Equal(expect, vend.sum);

        }
        [Fact]
        public void End()
        {
            var vend = new Vending();
            vend.InsertMoney(10);
            vend.InsertMoney(500);
            vend.EndTransaction();
            
            Assert.Equal(0, vend.sum);
        }

        Drink drink = new Drink(1, "Drink");
        Chips chips = new Chips(2, "Chips");
        Gum gum = new Gum(3, "Gum");
        [Fact]
        public void useDrink()
        {
            Assert.Equal("drink Drink",drink.Use());
        }
        [Fact]
        public void useChips()
        {
            Assert.Equal("eat Chips", chips.Use());
        }
        [Fact]
        public void useGum()
        {
            Assert.Equal("chew Gum", gum.Use());
        }
        [Fact]
        public void examineDrink()
        {
            Assert.Equal("Drink type:Drink prise:15kr position: 1", drink.Examin());
        }
        [Fact]
        public void examineChips()
        {
            Assert.Equal("Chips type:Chips prise:20kr position: 2", chips.Examin());
        }
        [Fact]
        public void examineGum()
        {
            Assert.Equal("Gum type:Gum prise:12kr position: 3", gum.Examin());
        }
        [Theory]
        [InlineData("Drink", "sos", 1, "sos")]
        public void add(string type, string name, int expect,string expect2)
        { 
            var prog= new Program();
            
            prog.addProduct(type, name);
            foreach(var c in prog.collect)
            {
                Assert.Equal(expect, c.ID);
                Assert.Equal(expect2, c.Name);
                                
            }
            
        }
        }
}
