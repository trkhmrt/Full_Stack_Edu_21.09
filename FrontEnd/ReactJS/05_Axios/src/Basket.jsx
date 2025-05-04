import React from "react";

const Basket = () => {
    return (
        <div className="max-w-6xl mx-auto px-4 py-10 grid grid-cols-1 md:grid-cols-3 gap-8">
            {/* Ürünler Bölümü */}
            <div className="md:col-span-2 space-y-6">
                <h2 className="text-3xl font-bold text-gray-800">Sepetim</h2>

                {/* Ürün Kartı */}
                <div className="flex items-center gap-5 border rounded-xl p-4 hover:shadow-lg transition">
                    <img
                        src="https://via.placeholder.com/100"
                        alt="Ürün"
                        className="w-24 h-24 object-cover rounded-xl border"
                    />
                    <div className="flex-1 space-y-1">
                        <h3 className="text-xl font-semibold text-gray-700">Minimalist Tişört</h3>
                        <p className="text-sm text-gray-500">Renk: Beyaz | Beden: M</p>
                        <p className="text-lg font-bold text-blue-600">₺249,00</p>

                        <div className="flex items-center gap-3 mt-2">
                            <button className="w-8 h-8 rounded-full bg-gray-200 hover:bg-gray-300">-</button>
                            <span className="text-sm">1</span>
                            <button className="w-8 h-8 rounded-full bg-gray-200 hover:bg-gray-300">+</button>
                        </div>
                    </div>

                    <button className="text-sm text-red-500 underline hover:text-red-700">Kaldır</button>
                </div>
                <div className="flex items-center gap-5 border rounded-xl p-4 hover:shadow-lg transition">
                    <img
                        src="https://via.placeholder.com/100"
                        alt="Ürün"
                        className="w-24 h-24 object-cover rounded-xl border"
                    />
                    <div className="flex-1 space-y-1">
                        <h3 className="text-xl font-semibold text-gray-700">Minimalist Tişört</h3>
                        <p className="text-sm text-gray-500">Renk: Beyaz | Beden: M</p>
                        <p className="text-lg font-bold text-blue-600">₺249,00</p>

                        <div className="flex items-center gap-3 mt-2">
                            <button className="w-8 h-8 rounded-full bg-gray-200 hover:bg-gray-300">-</button>
                            <span className="text-sm">1</span>
                            <button className="w-8 h-8 rounded-full bg-gray-200 hover:bg-gray-300">+</button>
                        </div>
                    </div>

                    <button className="text-sm text-red-500 underline hover:text-red-700">Kaldır</button>
                </div>
                <div className="flex items-center gap-5 border rounded-xl p-4 hover:shadow-lg transition">
                    <img
                        src="https://via.placeholder.com/100"
                        alt="Ürün"
                        className="w-24 h-24 object-cover rounded-xl border"
                    />
                    <div className="flex-1 space-y-1">
                        <h3 className="text-xl font-semibold text-gray-700">Minimalist Tişört</h3>
                        <p className="text-sm text-gray-500">Renk: Beyaz | Beden: M</p>
                        <p className="text-lg font-bold text-blue-600">₺249,00</p>

                        <div className="flex items-center gap-3 mt-2">
                            <button className="w-8 h-8 rounded-full bg-gray-200 hover:bg-gray-300">-</button>
                            <span className="text-sm">1</span>
                            <button className="w-8 h-8 rounded-full bg-gray-200 hover:bg-gray-300">+</button>
                        </div>
                    </div>

                    <button className="text-sm text-red-500 underline hover:text-red-700">Kaldır</button>
                </div>
                {/* Daha fazla ürün burada map ile çoğaltılabilir */}
            </div>

            {/* Sepet Özeti */}
            <div className="bg-white p-6 rounded-2xl shadow-xl h-fit">
                <h3 className="text-2xl font-semibold text-gray-800 mb-4">Sepet Özeti</h3>
                <div className="space-y-3 text-gray-700">
                    <div className="flex justify-between">
                        <span>Ara Toplam</span>
                        <span>₺249,00</span>
                    </div>
                    <div className="flex justify-between">
                        <span>Kargo</span>
                        <span>₺19,90</span>
                    </div>
                    <div className="border-t pt-2 flex justify-between font-bold text-lg text-gray-800">
                        <span>Toplam</span>
                        <span>₺268,90</span>
                    </div>
                </div>
                <button className="w-full mt-6 bg-blue-600 hover:bg-blue-700 text-white font-semibold py-3 rounded-xl transition">
                    Ödemeye Geç
                </button>
            </div>
        </div>
    );
};

export default Basket;
