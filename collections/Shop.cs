using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }
    }
    public class Creator
    {
        public int CreatorId { get; set; }
        public string Name { get; set; }
        public Creator(int creatorId, string name)
        {
            CreatorId = creatorId;
            Name = name;
        }
    }
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }
        public int CreatorId { get; set; }
        public List<Category> Categories { get; set; }
        public Product(int productId, string name,int creator)
        {
            ProductId = productId;
            Name = name;
            CreatorId = creator;
            Categories = new List<Category>();
        }
        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }
        public void RemoveCategory(int categoryId)
        {
            foreach (Category category in Categories) 
            {
                if(category.CategoryId == categoryId)
                {
                    Categories.Remove(category);
                }
            }
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int BuyerId {  get; set; }
        DateTime OrderDate { get; set; }
        Order(int orderId, int productId, int buyerId, DateTime orderDate)
        {
            OrderId = orderId;
            ProductId = productId;
            BuyerId = buyerId;
            OrderDate = new DateTime();
        }
    }
    public class Buyer
    {
        public int BuyerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        Buyer(int id, string name, string email)
        {
            id = id;
            Name = name;
            Email = email;
        }
    }
}
