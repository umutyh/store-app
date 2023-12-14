using store.Service.Models;
using AutoMapper;
using store.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using store.Database.ProductRepository;

namespace store.Service.ProductsService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repoProduct;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repoProduct, IMapper mapper)
        {
            _repoProduct = repoProduct;
            _mapper = mapper;
        }


        public async Task IncreasingTheSearchedProduct(int id)
        {
            var productData = (await _repoProduct.GetProductsAsync()).Where(x => x.ProductId == id).FirstOrDefault();

            if (productData == null)
            {
                throw new Exception("Error");
            }

            productData.Price += 10;

            await _repoProduct.UpdateProduct(productData, id);
        }


        public async Task<List<Products>> FindProductsByCategory(string category)
        {
            var productData = await _repoProduct.GetByCategory(category);


            if (!productData.Any())
            {
                throw new Exception("NOT FOUND!");
            }

            return _mapper.Map<List<Products>>(productData);

        }


        public async Task<Products> GetProductById(int id)
        {
            var productData = (await _repoProduct.GetProductsAsync()).Where(x => x.ProductId == id).SingleOrDefault();

            if (productData == null)
            {
                throw new Exception("Error");
            }

            return _mapper.Map<Products>(productData);
        }


        public async Task<List<Products>> GetProductsAsync()
        {
            return _mapper.Map<List<Products>>(await _repoProduct.GetProductsAsync());
        }


        public async Task<Products> CreateNewProduct(ProductForCreation product)
        {
            var mappedData = _mapper.Map<Table1>(product);


            if (product == null)
            {
                throw new Exception("Error");
            }

            var data = _mapper.Map<Products>(await _repoProduct.CreateProduct(mappedData));
            return data;

        }


        public async Task<Products> UpdateProducts(ProductForUpdating product, int id)
        {
            if (product == null)
            {
                throw new Exception("Error");
            }

            var mappedData = _mapper.Map<Table1>(product);

            return _mapper.Map<Products>(await _repoProduct.UpdateProduct(mappedData, id));
        }
    }
}
