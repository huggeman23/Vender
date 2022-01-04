using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Vender.Models;
using Vender.VendingMechine;


namespace Vender.Test
{
    public class UnitTest1
    {
       /* [Fact]
        public void Test1()
        {
            var prog = new Program();
            
            Assert.Equal(20, prog.idSelect());

        }*/
        
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

        Drink drink = new Drink(1, "Drink", 15);
        Chips chips = new Chips(2, "Chips", 20);
        Gum gum = new Gum(3, "Gum", 12);
        [Fact]
        public void useDrink()
        {
            Assert.Equal("drink soda",drink.Use());
        }
        [Fact]
        public void useChips()
        {
            Assert.Equal("eat chips", chips.Use());
        }
        [Fact]
        public void useGum()
        {
            Assert.Equal("chew gum", gum.Use());
        }
        [Fact]
        public void examineDrink()
        {
            Assert.Equal("Drink prise:15kr position: 1", drink.Examin());
        }
        [Fact]
        public void examineChips()
        {
            Assert.Equal("Chips prise:20kr position: 2", chips.Examin());
        }
        [Fact]
        public void examineGum()
        {
            Assert.Equal("Gum prise:12kr position: 3", gum.Examin());
        }

    }
}
