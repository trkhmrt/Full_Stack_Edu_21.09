using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.DataAccess.Extensions;

public static class SeedDataCreator
{
    public static void SeedDataCreate(this ModelBuilder modelBuilder)
    {
        #region User
        modelBuilder.Entity<User>().HasData(
            new User
            {
                userId = 1,
                userName    = "trk",
                email = "trk@trk.com",
                password = "123456",
                firstName = "tarik"
            },
            new User
            {
                userId = 2,
                userName    = "ysf",
                email = "ysf@ysf.com",
                password = "123456",
                firstName = "yusuf"
            },
            new User
            {
                userId = 3,
                userName    = "tna",
                email = "tna@tna.com",
                password = "123456",
                firstName = "tuna"
            },
            new User
            {
                userId = 4,
                userName    = "dhn",
                email = "dhn@dhn.com",
                password = "123456",
                firstName = "duhan"
            }

        );
        #endregion
        #region Role
        modelBuilder.Entity<Role>().HasData(
            new Role
            {
                roleId = 1,
                roleName    = "admin"
            },
            new Role
            {
                roleId = 2,
                roleName    = "customer"
            },
            new Role
            {
                roleId = 3,
                roleName    = "IT"
            }
            );
        #endregion
        #region UserRole

        modelBuilder.Entity<UserRole>().HasData(
            new UserRole
            {
                userId = 1,
                roleId = 1,
              
            },
            new UserRole
            {
                userId = 2,
                roleId = 2,
              
            },
            new UserRole
            {
                userId = 3,
                roleId = 3,
              
            },
            new UserRole
            {
                userId = 4,
                roleId = 2,
              
            }
            );

        #endregion
        #region Basket
        modelBuilder.Entity<Basket>().HasData(
            new Basket
            {
                basketId = 1,
                userId = 1,
                basketStatusId = 1
            },
            new Basket
            {
                basketId = 2,
                userId = 2,
                basketStatusId = 3
            },
            new Basket
            {
                basketId = 3,
                userId = 4,
                basketStatusId = 3
            }
        );
        #endregion

        #region BasketDetail
        modelBuilder.Entity<BasketDetail>().HasData(
            new BasketDetail
            {
                basketDetailId = 1,
                basketId = 1,
                basket_quantity = 1,
                productId = 1
                
            },
            new BasketDetail
            {
                basketDetailId = 2,
                basketId = 1,
                basket_quantity = 1,
                productId = 2
            },
            new BasketDetail
            {
                basketDetailId = 3,
                basketId = 2,
                basket_quantity = 1,
                productId = 3
                
            },
            new BasketDetail
            {
                basketDetailId = 4,
                basketId = 2,
                basket_quantity = 1,
                productId = 4
            }
        );
        #endregion

        #region BasketStatus
        modelBuilder.Entity<BasketStatus>().HasData(
            new BasketStatus
            {
                basketStatusId = 1,
                basketStatusName = "Sepet Aktif"
            },
            new BasketStatus
            {
                basketStatusId = 2,
                basketStatusName = "Sepet İptal"
            },
            new BasketStatus
            {
                basketStatusId = 3,
                basketStatusName = "Sepet Ödemeye Hazır"
            },
            new BasketStatus
            {
                basketStatusId = 4,
                basketStatusName = "Sepet Siparişe İletildi"
            }
        );
        
        #endregion

        #region Category
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                categoryId = 1,
                categoryName    = "giyim",
                categoryDescription = "Kılık Kıyafet Ayakkabı Giyim",
            },
            new Category
            {
                categoryId = 2,
                categoryName    = "elektronik",
                categoryDescription = "Elektrik Elektronik İhtiyaçlar",
            },
            new Category
            {
                categoryId = 3,
                categoryName    = "gıda",
                categoryDescription = "Gıda İhtiyaçları",
            }
        );
        #endregion

        #region SubCategory
        modelBuilder.Entity<SubCategory>().HasData(
            new SubCategory
            {
                subCategoryId = 1,
                subCategoryName    = "alt giyim",
                subCategoryDescription = "Alt giyim ürünleri",
                categoryId = 1
                
            },
            new SubCategory
            {
                subCategoryId = 2,
                subCategoryName    = "üst giyim",
                subCategoryDescription = "üst giyim ürünleri",
                categoryId = 1
            },
            new SubCategory
            {
                subCategoryId = 3,
                subCategoryName    = "İç giyim",
                subCategoryDescription = "İç giyim ürünleri",
                categoryId = 1
            },
            new SubCategory
            {
                subCategoryId = 4,
                subCategoryName    = "Akıllı Telefon",
                subCategoryDescription = "Android Akıllı Cihazlar",
                categoryId = 2
                    
            },
            new SubCategory
            {
                subCategoryId = 5,
                subCategoryName    = "Oyun Konslu",
                subCategoryDescription = "Oyun Konsol ürünleri",
                categoryId = 2
            },
            new SubCategory
            {
                subCategoryId = 6,
                subCategoryName    = "Televizyon",
                subCategoryDescription = "Televizyon ürünleri",
                categoryId = 2
            }
        );
        #endregion

        #region Order

        modelBuilder.Entity<Order>().HasData(
            new Order
            {
                orderId = 1,
                userId = 2,
                basketId = 1,
                orderDate = DateTime.Now,
                totalAmount = 400,
                orderStatusId = 3
            },
            new Order
            {
                orderId = 2,
                userId = 4,
                basketId = 2,
                orderDate = DateTime.Now,
                totalAmount = 850,
                orderStatusId = 3
            }
        );
        #endregion

        #region OrderDetail

        modelBuilder.Entity<OrderDetail>().HasData(
            new OrderDetail
            {
                orderId = 1,
                orderDetailId = 1,
                productId = 1,
                order_product_quantity = 2,
                order_product_totalPrice = 400
            },
            new OrderDetail
            {
                orderId = 1,
                orderDetailId = 2,
                productId = 3,
                order_product_quantity = 1,
                order_product_totalPrice = 150

            },
            new OrderDetail
            {
                orderId = 2,
                orderDetailId = 3,
                productId = 4,
                order_product_quantity = 1,
                order_product_totalPrice = 350

            },
            new OrderDetail
            {
                orderId = 2,
                orderDetailId = 4,
                productId = 5,
                order_product_quantity = 1,
                order_product_totalPrice = 650

            }

        );
        #endregion
        #region OrderStatus

        modelBuilder.Entity<OrderStatus>().HasData(
            new OrderStatus
            {
                orderStatusId = 1,
                orderStatusName = "Sipariş Aktif",
            },
            new OrderStatus
            {
                orderStatusId = 2,
                orderStatusName = "Sipariş İptal",
            },
            new OrderStatus
            {
                orderStatusId = 3,
                orderStatusName = "Sipariş Kargoya Verildi",
            },
            new OrderStatus
            {
                orderStatusId = 4,
                orderStatusName = "Sipariş Tamamlandı",
            }
        );
        #endregion

        #region Product

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                productId = 1,
                productName = "Playstation 5",
                productDescription = "Ps5 Oyun Konsolu",
                productUnitPrice = 10000,
                subCategoryId = 5,
                isProductActive = true
            },
            new Product
            {
                productId = 2,
                productName = "Xbox",
                productDescription = "Xbox Oyun Konsolu",
                productUnitPrice = 12000,
                subCategoryId = 5,
                isProductActive = true
            },
            new Product
            {
                productId = 3,
                productName = "Bot",
                productDescription = "Kışlık Su Geçirmez Bot",
                productUnitPrice = 2000,
                subCategoryId = 1,
                isProductActive = true
            },
            new Product
            {
                productId = 4,
                productName = "Çizme",
                productDescription = "Suya dayanıklı Çizme",
                productUnitPrice = 4500,
                subCategoryId = 1,
                isProductActive = true
            },
            new Product
            {
                productId = 5,
                productName = "Gömlek",
                productDescription = "Ekoseli Gömlek",
                productUnitPrice = 600,
                subCategoryId = 2,
                isProductActive = true
            },
            new Product
            {
                productId = 6,
                productName = "Kazak",
                productDescription = "Boğazlı Kazak",
                productUnitPrice = 670,
                subCategoryId = 2,
                isProductActive = true
            }
        );

        #endregion
        #region PaymentStatus

        modelBuilder.Entity<PaymentStatus>().HasData(
            new PaymentStatus
            {
                paymentStatusId = 1,
                paymentStatusName = "Ödendi",
            },
            new PaymentStatus
            {
                paymentStatusId = 2,
                paymentStatusName = "İade edildi",
            },
            new PaymentStatus
            {
                paymentStatusId = 3,
                paymentStatusName = "İptal edildi"
            }
        );

        #endregion

    }
}