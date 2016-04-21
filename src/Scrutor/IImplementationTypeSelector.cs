using System;
using Microsoft.Extensions.DependencyInjection;

namespace Scrutor
{
    public interface IImplementationTypeSelector : IAssemblySelector
    {
        /// <summary>
        /// Adds all public, non-abstract classes from the selected assemblies that are annotated with
        /// the <see cref="ServiceDescriptorAttribute"/> to the <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>.
        /// </summary>
        void AddFromAttributes();

        /// <summary>
        /// Adds all non-abstract classes from the selected assemblies that are annotated with
        /// the <see cref="ServiceDescriptorAttribute"/> to the <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>.
        /// </summary>
        /// <param name="publicOnly">Specifies whether too look at public types only.</param>
        void AddFromAttributes(bool publicOnly);

        /// <summary>
        /// Adds all public, non-abstract classes from the selected assemblies that are annotated with
        /// the <see cref="ServiceDescriptorAttribute"/> and that matches the requirements specified
        /// in the <paramref name="action"/> to the <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>.
        /// </summary>
        /// <param name="action">The filtering action.</param>
        void AddFromAttributes(Action<IImplementationTypeFilter> action);

        /// <summary>
        /// Adds all non-abstract classes from the selected assemblies that are annotated with
        /// the <see cref="ServiceDescriptorAttribute"/> and that matches the requirements specified
        /// in the <paramref name="action"/> to the <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>.
        /// </summary>
        /// <param name="action">The filtering action.</param>
        /// <param name="publicOnly">Specifies whether too look at public types only.</param>
        void AddFromAttributes(Action<IImplementationTypeFilter> action, bool publicOnly);

        /// <summary>
        /// Adds all public, non-abstract classes from the selected assemblies to the <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>.
        /// </summary>
        IServiceTypeSelector AddClasses();

        /// <summary>
        /// Adds all non-abstract classes from the selected assemblies to the <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>.
        /// </summary>
        /// <param name="publicOnly">Specifies whether too add public types only.</param>
        IServiceTypeSelector AddClasses(bool publicOnly);

        /// <summary>
        /// Adds all public, non-abstract classes from the selected assemblies that
        /// matches the requirements specified in the <paramref name="action"/>
        /// to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="action">The filtering action.</param>
        /// <exception cref="ArgumentNullException">If the <paramref name="action"/> argument is <c>null</c>.</exception>
        IServiceTypeSelector AddClasses(Action<IImplementationTypeFilter> action);

        /// <summary>
        /// Adds all non-abstract classes from the selected assemblies that
        /// matches the requirements specified in the <paramref name="action"/>
        /// to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="action">The filtering action.</param>
        /// <exception cref="ArgumentNullException">If the <paramref name="action"/> argument is <c>null</c>.</exception>
        /// <param name="publicOnly">Specifies whether too add public types only.</param>
        IServiceTypeSelector AddClasses(Action<IImplementationTypeFilter> action, bool publicOnly);
    }
}
