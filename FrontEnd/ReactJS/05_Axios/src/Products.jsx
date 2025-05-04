import React, { useState } from "react";

const ProductPage = () => {
    const [selectedCategory, setSelectedCategory] = useState(null);

    const categories = [
        {
            name: "Giyim",
            sub: ["Tişört", "Pantolon", "Mont"],
        },
        {
            name: "Elektronik",
            sub: ["Telefon", "Tablet", "Bilgisayar"],
        },
        {
            name: "Ev & Yaşam",
            sub: ["Mobilya", "Dekorasyon", "Mutfak"],
        },
    ];

    const products = [
        { title: "Minimalist Tişört", price: 249, image: "https://via.placeholder.com/150", category: "Tişört" },
        { title: "Modern Koltuk", price: 1450, image: "https://via.placeholder.com/150", category: "Mobilya" },
        { title: "Notebook", price: 7999, image: "https://via.placeholder.com/150", category: "Bilgisayar" },
    ];

    const filteredProducts = selectedCategory
        ? products.filter((p) => p.category === selectedCategory)
        : products;

    return (
        <div className="max-w-7xl mx-auto px-4 py-10 grid grid-cols-1 md:grid-cols-4 gap-8">

            {/* Sol Menü */}
            <aside className="md:col-span-1 space-y-6">
                <h2 className="text-xl font-bold text-gray-800">Kategoriler</h2>
                {categories.map((cat, index) => (
                    <details key={index} className="bg-gray-100 rounded-xl p-3">
                        <summary className="cursor-pointer font-medium text-gray-700">
                            {cat.name}
                        </summary>
                        <div className="mt-2 space-y-1 pl-3">
                            {cat.sub.map((sub, i) => (
                                <button
                                    key={i}
                                    onClick={() => setSelectedCategory(sub)}
                                    className={`block w-full text-left text-sm px-2 py-1 rounded hover:bg-blue-100 ${
                                        selectedCategory === sub ? "bg-blue-200 font-semibold" : ""
                                    }`}
                                >
                                    {sub}
                                </button>
                            ))}
                        </div>
                    </details>
                ))}
                {selectedCategory && (
                    <button
                        onClick={() => setSelectedCategory(null)}
                        className="text-sm text-red-500 underline"
                    >
                        Filtreyi Temizle
                    </button>
                )}
            </aside>

            {/* Ürünler */}
            <section className="md:col-span-3 grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-6">
                {filteredProducts.map((product, index) => (
                    <div key={index} className="border rounded-2xl p-4 shadow-sm hover:shadow-md transition">
                        <img
                            src={product.image}
                            alt={product.title}
                            className="w-full h-40 object-cover rounded-lg mb-3"
                        />
                        <h3 className="text-lg font-semibold text-gray-800">{product.title}</h3>
                        <p className="text-blue-600 font-bold mt-1">₺{product.price}</p>
                        <button className="mt-3 w-full bg-blue-600 hover:bg-blue-700 text-white py-2 rounded-xl text-sm font-semibold">
                            Sepete Ekle
                        </button>
                    </div>
                ))}
            </section>
        </div>
    );
};

export default ProductPage;
