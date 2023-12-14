using AutoMapper;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using XStoreApp.ServiceClient;
using XStoreApp.ServiceClient.Models;
using XStore.ServiceClient;

namespace XStore.Service.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly StoreAPI apiClient = new StoreAPI() { BaseUri = new Uri("http://10.0.2.2:5122/") };
        private readonly AesEncryptionService _aesEncryptionService;
        public ProductService(IMapper mapper)
        {
            _mapper = mapper;
            _aesEncryptionService = new AesEncryptionService(GlobalConstants.encryptionKey);
        }

        public async Task IncreasingTheSearchedProduct(int id)
        {
            var productData = await apiClient.GetResultWithProductIdWithHttpMessagesAsync(id);

            if (productData.Response.IsSuccessStatusCode)
            {
                if (productData.Body == null)
                {
                    throw new Exception("Error");
                }

                var product = productData.Body;
                product.Price += 10;
                var mappedData = _mapper.Map<ProductForUpdating>(product);
                await apiClient.UpdateProductWithHttpMessagesAsync(id, mappedData);
            }

        }

        public async Task<List<Products>> FindProductsByCategory(string category)
        {
            var productData = await apiClient.GetProductsByCategoryWithHttpMessagesAsync(category);
            if (productData.Response.IsSuccessStatusCode)
            {
                if (productData.Body == null)
                {
                    throw new Exception("Error");
                }
                var mappedData = _mapper.Map<List<Products>>(productData);
                return mappedData.ToList();
            }
            return new List<Products>();
        }

        public async Task<Products> GetProductById(int id)
        {
            var productData = await apiClient.GetResultWithProductIdWithHttpMessagesAsync(id);

            if (productData.Response.IsSuccessStatusCode)
            {
                if (productData.Body == null)
                {
                    throw new Exception("Error");
                }

                return _mapper.Map<Products>(productData.Body);
            }
            return null;
        }

        public async Task<IEnumerable<Products>> GetProductsAsync()
        {
            var products = await apiClient.GetProductsWithHttpMessagesAsync();
            if (products.Response.IsSuccessStatusCode)
            {
                return products.Body.ToList();
            }
            return null;
        }

        public async Task<Products> CreateNewProduct(ProductForCreation product)
        {
            if (product == null)
            {
                throw new Exception("Error");
            }
            var mappedData = _mapper.Map<Products>(product);
            var mappedCreation = _mapper.Map<ProductForCreation>(mappedData);
            return _mapper.Map<Products>(await apiClient.CreateProductWithHttpMessagesAsync(mappedCreation));

        }

        public async Task<Products> UpdateProducts(ProductForUpdating product, int id)
        {
            if (product == null)
            {
                throw new Exception("Error");
            }

            var mappedData = _mapper.Map<Products>(product);
            var mappedUpdating = _mapper.Map<ProductForUpdating>(mappedData);
            return _mapper.Map<Products>(await apiClient.UpdateProductWithHttpMessagesAsync(id, mappedUpdating));
        }
    }
}
