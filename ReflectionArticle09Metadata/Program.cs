using AutoMapper;
using System.Reflection;

namespace ReflectionArticle09Metadata
{
    /// <summary>
    /// Custom attribute to add metadata descriptions to classes and methods.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    sealed class MyMetadataAttribute : Attribute
    {
        /// <summary>
        /// Gets the description associated with the metadata attribute.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyMetadataAttribute"/> class.
        /// </summary>
        /// <param name="description">The description to associate with the metadata.</param>
        public MyMetadataAttribute(string description)
        {
            Description = description;
        }
    }

    /// <summary>
    /// A class responsible for displaying metadata associated with types, methods, and properties.
    /// </summary>
    class MetadataRepository
    {
        /// <summary>
        /// Displays metadata for a given type.
        /// </summary>
        /// <param name="type">The type to display metadata for.</param>
        public static void DisplayMetadata(Type type)
        {
            // Get class-level metadata attributes
            var attributes = type.GetCustomAttributes(typeof(MyMetadataAttribute), true);
            foreach (MyMetadataAttribute attribute in attributes)
            {
                Console.WriteLine($"Class Metadata: {attribute.Description}");
            }

            // Get method-level metadata attributes for all methods in the type
            foreach (MethodInfo method in type.GetMethods())
            {
                var methodAttributes = method.GetCustomAttributes(typeof(MyMetadataAttribute), true);
                foreach (MyMetadataAttribute attribute in methodAttributes)
                {
                    Console.WriteLine($"Method Metadata: {attribute.Description}");
                }
            }

            // Get the properties of the type and display their names
            var properties = type.GetProperties();
            Console.WriteLine("Properties:");
            foreach (var property in properties)
            {
                Console.WriteLine($"- {property.Name}");
            }
        }
    }

    /// <summary>
    /// Represents a source class with metadata.
    /// </summary>
    class MySourceClass
    {
        /// <summary>
        /// Gets or sets the source property.
        /// </summary>
        public string SourceProperty { get; set; }

        /// <summary>
        /// A sample method with metadata.
        /// </summary>
        [MyMetadata("This is a sample source method.")]
        public void MyMethod()
        {
            Console.WriteLine("Executing MyMethod");
        }
    }

    /// <summary>
    /// Represents a destination class with metadata.
    /// </summary>
    class MyDestinationClass
    {
        /// <summary>
        /// Gets or sets the destination property.
        /// </summary>
        public string DestinationProperty { get; set; }

        /// <summary>
        /// A sample method with metadata.
        /// </summary>
        [MyMetadata("This is a sample destination method.")]
        public void MyMethod()
        {
            Console.WriteLine("Executing MyMethod");
        }
    }

    class Program
    {
        static void Main()
        {
            // Configure AutoMapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MySourceClass, MyDestinationClass>();
            });

            var mapper = new Mapper(mapperConfig);

            var source = new MySourceClass
            {
                SourceProperty = "Source Data",
            };

            Console.WriteLine("Metadata for MySourceClass:");
            MetadataRepository.DisplayMetadata(source.GetType());

            var destination = mapper.Map<MyDestinationClass>(source);

            Console.WriteLine("\nMetadata for MyDestinationClass:");
            MetadataRepository.DisplayMetadata(destination.GetType());
        }
    }
}
