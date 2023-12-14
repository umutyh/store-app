using Autofac;
using XStoreApp.Models;
using System.Collections.ObjectModel;
using XStoreApp.Autofac;
using System.Threading.Tasks;
using System.Collections.Generic;
using XStoreApp.ServiceClient.Models;
using AutoMapper;
using System;
using XStore.Service.ProductService;

namespace XStoreApp.ViewModel
{
    public class ProductViewModel : AbstractViewModel
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        private ObservableCollection<ProductModel> _products = new ObservableCollection<ProductModel>();
        public ObservableCollection<ProductModel> Products
        {
           
            get { return _products; }
            set
            {
                if (_products!=value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }

        public ProductViewModel()
        {
            _mapper = AppContainer.Container.Resolve<IMapper>();
            _productService = AppContainer.Container.Resolve<IProductService>();
           Products = new ObservableCollection<ProductModel>();
        }

        public async Task<Products>ProductById(int id)
        {
            var productData = await _productService.GetProductById(id);

            var productModels = _mapper.Map<IEnumerable<ProductModel>>(productData);

            var productCollection = new ObservableCollection<ProductModel>(productModels);

            return _mapper.Map<Products>(productCollection);
        }

        public async Task<List<Products>>FindByCategory(string category)
        {
            var productData = await _productService.FindProductsByCategory(category);

            var productModels = _mapper.Map<IEnumerable<ProductModel>>(productData);

            var productCollection = new ObservableCollection<ProductModel>(productModels);
            return _mapper.Map<List<Products>>(productCollection);
        }

        public async Task GetProducts()
        { 
   
            try
            {
                var products = await _productService.GetProductsAsync();

                var data = _mapper.Map<ObservableCollection<ProductModel>>(products);

                Products = data;
            }
            catch (Exception ex)
            {
                // Handle exception
                throw new Exception("drdr");
            }
        }

        public async Task<Products>CreateProduct(ProductForCreation product)
        {
            var productData = await _productService.CreateNewProduct(product);

            var productModels = _mapper.Map<IEnumerable<ProductModel>>(productData);

            var productCollection = new ObservableCollection<ProductModel>(productModels);

            return _mapper.Map<Products>(productCollection); 
        }

        public async Task<Products>UpdateProduct(ProductForUpdating product, int id) 
        {
            var productData = await _productService.UpdateProducts(product, id);

            var productModels = _mapper.Map<IEnumerable<ProductModel>>(productData);

            var productCollection = new ObservableCollection<ProductModel>(productModels);
            return _mapper.Map<Products>(productCollection);
        }

    }
}
