namespace Unity.MLAgents.Sensors
{
    /// <summary>
    /// Sensor interface for generating observations.
    /// </summary>
    public interface ICompressibleSensor : ISensor
    {
        /// <summary>
        /// Returns the mapping of the channels in compressed data to the
        /// actual channel after decompression.
        /// The mapping is a list of interger index with the same length as
        /// the number of layers (channels) of the sensor.
        /// Each index indicates the actual channel the layer will go into.
        /// Layers with the same index will be averaged, and layers with negative index will be dropped.
        /// For example, mapping for CameraSensor using grayscale and stacking of two: [0, 0, 0, 1, 1, 1]
        /// Mapping for GridSensor of 4 channels and stacking of two: [0, 1, 2, 3, -1, -1, 4, 5, 6, 7, -1, -1]
        /// </summary>
        /// <returns>Mapping of the compressed data</returns>
        int[] GetCompressionMapping();
    }
}