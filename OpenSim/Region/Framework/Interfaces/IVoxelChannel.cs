using OpenMetaverse;
using System;
using System.Collections.Generic;

namespace OpenSim.Region.Framework.Interfaces
{
	/// <summary>
	/// 3D grid of voxels
	/// </summary>
	public interface IVoxelChannel
	{
		int Height { get; }		// Z
		int Length { get; } 	// Y
        int Width  { get; } 	// X
		
        int this[int x, int y, int z] { get; set; }
		
		bool IsSolid(int x,int y,int z);

        /// <summary>
        /// Squash the entire voxelspace into a single dimensioned array
        /// </summary>
        /// <returns></returns>
        bool[] GetBoolsSerialised();
		float[] GetFloatsSerialised();
		
        double[,] GetDoubles();
		
        bool Tainted(int x, int y, int z);
        IVoxelChannel MakeCopy();
        string SaveToXmlString();
        void LoadFromXmlString(string data);

        void Generate(string method, long seed, long X, long Y);
		
		void Save(string name);
		void Load(string name);
		
		bool IsInsideTerrain(Vector3 pos);
		Vector3 FindNearestAirVoxel(Vector3 subject, bool ForAvatar);

        byte[] GetChunk(int X, int Y);

        bool[] GetSolidsArray();
    }
}
