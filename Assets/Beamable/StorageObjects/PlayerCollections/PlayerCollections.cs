using Beamable.Common;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Beamable.Server
{
	[StorageObject("PlayerCollections")]
	public class PlayerCollections : MongoStorageObject
	{
	}

	public class CollectedItem
	{
		public ObjectId Id;
		public string Address;
		public int Points;
	}

	public static class PlayerCollectionsExtension
	{
		/// <summary>
		/// Get an authenticated MongoDB instance for PlayerCollections
		/// </summary>
		/// <returns></returns>
		public static Promise<IMongoDatabase> PlayerCollectionsDatabase(this IStorageObjectConnectionProvider provider)
			=> provider.GetDatabase<PlayerCollections>();

		/// <summary>
		/// Gets a MongoDB collection from PlayerCollections by the requested name, and uses the given mapping class.
		/// If you don't want to pass in a name, consider using <see cref="PlayerCollectionsCollection{TCollection}()"/>
		/// </summary>
		/// <param name="name">The name of the collection</param>
		/// <typeparam name="TCollection">The type of the mapping class</typeparam>
		/// <returns>When the promise completes, you'll have an authorized collection</returns>
		public static Promise<IMongoCollection<TCollection>> PlayerCollectionsCollection<TCollection>(
			this IStorageObjectConnectionProvider provider, string name)
			where TCollection : StorageDocument
			=> provider.GetCollection<PlayerCollections, TCollection>(name);

		/// <summary>
		/// Gets a MongoDB collection from PlayerCollections by the requested name, and uses the given mapping class.
		/// If you want to control the collection name separate from the class name, consider using <see cref="PlayerCollectionsCollection{TCollection}(string)"/>
		/// </summary>
		/// <param name="name">The name of the collection</param>
		/// <typeparam name="TCollection">The type of the mapping class</typeparam>
		/// <returns>When the promise completes, you'll have an authorized collection</returns>
		public static Promise<IMongoCollection<TCollection>> PlayerCollectionsCollection<TCollection>(
			this IStorageObjectConnectionProvider provider)
			where TCollection : StorageDocument
			=> provider.GetCollection<PlayerCollections, TCollection>();
	}
}
