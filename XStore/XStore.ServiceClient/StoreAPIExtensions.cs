// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XStoreApp.ServiceClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StoreAPI.
    /// </summary>
    public static partial class StoreAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<OrderInfoServiceDB> GetOrderInformation(this IStoreAPI operations)
            {
                return operations.GetOrderInformationAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<OrderInfoServiceDB>> GetOrderInformationAsync(this IStoreAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOrderInformationWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void CreateOrderInfo(this IStoreAPI operations, OrderInfoCreation body = default(OrderInfoCreation))
            {
                operations.CreateOrderInfoAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateOrderInfoAsync(this IStoreAPI operations, OrderInfoCreation body = default(OrderInfoCreation), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateOrderInfoWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<OrderDetailServiceDB> GetOrderDetails(this IStoreAPI operations)
            {
                return operations.GetOrderDetailsAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<OrderDetailServiceDB>> GetOrderDetailsAsync(this IStoreAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOrderDetailsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void CreateOrderDetails(this IStoreAPI operations, OrderDetailCreation body = default(OrderDetailCreation))
            {
                operations.CreateOrderDetailsAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateOrderDetailsAsync(this IStoreAPI operations, OrderDetailCreation body = default(OrderDetailCreation), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateOrderDetailsWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<OrderDetailsCombined> JoinedOrderDetailsAndInformation(this IStoreAPI operations)
            {
                return operations.JoinedOrderDetailsAndInformationAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<OrderDetailsCombined>> JoinedOrderDetailsAndInformationAsync(this IStoreAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.JoinedOrderDetailsAndInformationWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderNumber'>
            /// </param>
            public static IList<OrderInfoServiceDB> GetOrderByOrderNumber(this IStoreAPI operations, int orderNumber)
            {
                return operations.GetOrderByOrderNumberAsync(orderNumber).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderNumber'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<OrderInfoServiceDB>> GetOrderByOrderNumberAsync(this IStoreAPI operations, int orderNumber, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOrderByOrderNumberWithHttpMessagesAsync(orderNumber, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderNumber'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static OrderDetailServiceDB UpdateOrderPrice(this IStoreAPI operations, int orderNumber, OrderForUpdatingPriceAndQuantity body = default(OrderForUpdatingPriceAndQuantity))
            {
                return operations.UpdateOrderPriceAsync(orderNumber, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderNumber'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrderDetailServiceDB> UpdateOrderPriceAsync(this IStoreAPI operations, int orderNumber, OrderForUpdatingPriceAndQuantity body = default(OrderForUpdatingPriceAndQuantity), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateOrderPriceWithHttpMessagesAsync(orderNumber, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderNumber'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static OrderDetailServiceDB UpdateOrderPriceAndQuantity(this IStoreAPI operations, int? orderNumber = default(int?), OrderForUpdatingPriceAndQuantity body = default(OrderForUpdatingPriceAndQuantity))
            {
                return operations.UpdateOrderPriceAndQuantityAsync(orderNumber, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderNumber'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrderDetailServiceDB> UpdateOrderPriceAndQuantityAsync(this IStoreAPI operations, int? orderNumber = default(int?), OrderForUpdatingPriceAndQuantity body = default(OrderForUpdatingPriceAndQuantity), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateOrderPriceAndQuantityWithHttpMessagesAsync(orderNumber, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Products> GetProducts(this IStoreAPI operations)
            {
                return operations.GetProductsAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Products>> GetProductsAsync(this IStoreAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProductsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void CreateProduct(this IStoreAPI operations, ProductForCreation body = default(ProductForCreation))
            {
                operations.CreateProductAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateProductAsync(this IStoreAPI operations, ProductForCreation body = default(ProductForCreation), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateProductWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Products GetResultWithProductId(this IStoreAPI operations, int id)
            {
                return operations.GetResultWithProductIdAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Products> GetResultWithProductIdAsync(this IStoreAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResultWithProductIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static Products UpdateProduct(this IStoreAPI operations, int id, ProductForUpdating body = default(ProductForUpdating))
            {
                return operations.UpdateProductAsync(id, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Products> UpdateProductAsync(this IStoreAPI operations, int id, ProductForUpdating body = default(ProductForUpdating), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateProductWithHttpMessagesAsync(id, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void IncreasingTheSearchedProduct(this IStoreAPI operations, int id)
            {
                operations.IncreasingTheSearchedProductAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task IncreasingTheSearchedProductAsync(this IStoreAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.IncreasingTheSearchedProductWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// </param>
            public static IList<Products> GetProductsByCategory(this IStoreAPI operations, string category)
            {
                return operations.GetProductsByCategoryAsync(category).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Products>> GetProductsByCategoryAsync(this IStoreAPI operations, string category, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProductsByCategoryWithHttpMessagesAsync(category, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<UsersServiceDB> Users(this IStoreAPI operations)
            {
                return operations.UsersAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<UsersServiceDB>> UsersAsync(this IStoreAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UsersWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void Login(this IStoreAPI operations, UsersServiceDB body = default(UsersServiceDB))
            {
                operations.LoginAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task LoginAsync(this IStoreAPI operations, UsersServiceDB body = default(UsersServiceDB), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.LoginWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
