using System;

namespace PKHeX.Core;

/// <summary>
/// Details about moves in <see cref="EntityContext.Gen8a"/>
/// </summary>
internal static class MoveInfo8a
{
    public static ReadOnlySpan<byte> MovePP_LA =>
    [
        00, 35, 25, 10, 15, 20, 20, 10, 10, 10, 35, 30, 05, 10, 20, 30, 25, 35, 20, 15,
        20, 20, 25, 20, 30, 05, 10, 15, 15, 15, 25, 20, 05, 30, 15, 20, 20, 10, 05, 30,
        20, 20, 20, 30, 20, 40, 20, 15, 20, 20, 20, 30, 25, 10, 30, 25, 05, 15, 10, 05,
        20, 20, 20, 05, 35, 20, 20, 20, 20, 20, 15, 20, 15, 10, 20, 25, 10, 20, 20, 20,
        10, 40, 10, 15, 25, 10, 20, 05, 15, 10, 05, 10, 10, 20, 10, 20, 40, 30, 20, 20,
        20, 15, 10, 40, 15, 10, 30, 10, 20, 10, 40, 40, 20, 30, 30, 20, 20, 10, 10, 20,
        05, 10, 30, 20, 20, 20, 05, 15, 15, 20, 10, 15, 35, 20, 15, 10, 10, 30, 15, 20,
        20, 10, 10, 05, 10, 25, 10, 10, 20, 15, 40, 20, 10, 05, 15, 10, 10, 10, 15, 30,
        30, 10, 10, 15, 10, 01, 01, 10, 25, 10, 05, 15, 20, 15, 10, 15, 30, 05, 40, 15,
        10, 25, 10, 20, 10, 20, 10, 10, 10, 20, 15, 20, 05, 40, 05, 05, 20, 05, 10, 05,
        10, 10, 10, 10, 20, 20, 30, 15, 10, 20, 20, 25, 05, 15, 10, 05, 20, 15, 20, 25,
        20, 05, 30, 05, 05, 20, 40, 05, 20, 40, 20, 05, 35, 10, 05, 05, 05, 15, 05, 25,
        05, 05, 10, 20, 10, 05, 15, 10, 10, 20, 15, 10, 10, 10, 20, 10, 10, 10, 10, 15,
        15, 15, 10, 20, 20, 10, 20, 20, 20, 20, 20, 10, 10, 10, 20, 20, 05, 15, 10, 10,
        15, 10, 20, 05, 05, 10, 10, 20, 05, 10, 20, 10, 20, 20, 20, 05, 05, 15, 20, 10,
        15, 20, 15, 10, 10, 15, 10, 05, 05, 10, 25, 10, 05, 20, 15, 05, 40, 15, 15, 40,
        15, 20, 20, 05, 15, 20, 15, 15, 15, 05, 10, 30, 20, 30, 20, 05, 40, 10, 05, 10,
        05, 15, 25, 25, 05, 20, 15, 10, 10, 20, 10, 20, 20, 05, 05, 10, 05, 40, 10, 10,
        05, 10, 10, 15, 10, 20, 15, 30, 10, 20, 05, 10, 10, 15, 10, 10, 05, 15, 05, 10,
        10, 30, 20, 20, 10, 10, 05, 05, 10, 05, 20, 10, 20, 10, 05, 10, 10, 20, 10, 10,
        15, 10, 15, 10, 10, 10, 10, 10, 10, 10, 30, 05, 10, 05, 10, 10, 05, 20, 20, 10,
        20, 15, 15, 15, 15, 20, 15, 15, 10, 10, 10, 20, 15, 05, 05, 15, 15, 05, 10, 05,
        15, 05, 10, 20, 05, 20, 20, 20, 20, 05, 20, 15, 05, 20, 15, 10, 10, 05, 10, 05,
        05, 10, 05, 05, 10, 05, 15, 05, 15, 10, 10, 10, 10, 10, 15, 15, 20, 15, 10, 15,
        10, 15, 10, 20, 10, 10, 10, 20, 20, 20, 20, 20, 15, 15, 15, 15, 15, 15, 20, 15,
        10, 15, 15, 15, 15, 10, 15, 10, 10, 10, 15, 15, 15, 15, 05, 05, 15, 05, 10, 10,
        10, 20, 20, 20, 10, 10, 30, 15, 10, 10, 15, 25, 10, 15, 10, 10, 10, 20, 10, 10,
        10, 10, 05, 15, 15, 05, 05, 10, 10, 10, 05, 05, 10, 05, 05, 15, 10, 05, 05, 05,
        10, 10, 10, 10, 20, 25, 10, 20, 30, 25, 20, 20, 15, 20, 15, 20, 20, 15, 10, 10,
        10, 10, 20, 10, 25, 10, 10, 10, 10, 20, 20, 05, 05, 05, 20, 10, 10, 20, 15, 20,
        20, 10, 20, 30, 10, 10, 40, 40, 20, 20, 40, 20, 20, 10, 10, 10, 10, 05, 10, 10,
        05, 05, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01,
        01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 01, 10,
        10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 25, 15, 20, 30, 20, 15, 15, 20, 10, 15,
        15, 10, 05, 10, 10, 20, 15, 10, 15, 15, 15, 05, 15, 20, 20, 01, 01, 01, 01, 01,
        01, 01, 01, 01, 05, 05, 10, 10, 10, 20, 10, 10, 10, 05, 05, 20, 10, 10, 10, 01,
        05, 15, 05, 01, 01, 01, 01, 01, 01, 10, 15, 15, 20, 20, 20, 20, 15, 15, 10, 10,
        05, 20, 05, 10, 05, 15, 10, 10, 05, 15, 20, 10, 10, 15, 10, 10, 10, 10, 10, 10,
        10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 05, 10, 15, 10, 15,
        05, 05, 05, 10, 15, 40, 10, 10, 10, 15, 10, 10, 10, 10, 05, 05, 05, 10, 05, 20,
        10, 10, 05, 20, 20, 10, 10, 05, 05, 05, 40, 10, 20, 10, 10, 10, 10, 05, 05, 15,
        05, 10, 10, 10, 05, 05, 35, 15, 10, 10, 15, 05, 10, 10, 10, 05, 05, 10, 05, 15,
        10, 15, 10, 15, 15, 15, 05, 05, 05, 10, 10,
    ];

    /// <summary>
    /// Bitflag indexes of moves that are not usable in game.
    /// </summary>
    /// <remarks>
    /// This is a bitflag array, where each bit represents a move. If the bit is set, the move is not usable in game.
    /// Instead of allocating a hashset, this is a more efficient method (no allocation) with O(1) lookup (faster than HashSet's O(1) lookup).
    /// </remarks>
    public static ReadOnlySpan<byte> DummiedMoves => // 673 moves (1346 bytes) => 104 bytes.
    [
        0x7E, 0xBC, 0xFE, 0xFF, 0xBD, 0xEA, 0xCF, 0x72, 0x7F, 0x1F,
        0x0E, 0x1F, 0xAB, 0xFD, 0xEF, 0xBE, 0x7D, 0xD7, 0x35, 0xCF,
        0xD5, 0xEF, 0x5F, 0x0F, 0xEF, 0x9E, 0xFD, 0xFF, 0x7E, 0x5F,
        0x3B, 0xFD, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF, 0xBF, 0xB3,
        0xBF, 0xAF, 0xF5, 0xE4, 0xF6, 0xFF, 0xFB, 0xFF, 0xFF, 0x2B,
        0x84, 0x8C, 0x08, 0xA0, 0xDB, 0xAA, 0xC5, 0x21, 0xF0, 0xFB,
        0xFF, 0xF7, 0xFF, 0xFB, 0xFF, 0xF3, 0xFE, 0xBF, 0xFF, 0xE7,
        0xFF, 0xFF, 0x7D, 0xFC, 0xF7, 0xDF, 0xFE, 0xFF, 0xFF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xB7, 0xFF, 0xFF, 0xFF, 0xFF, 0xBF, 0xFF,
        0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xEF,
        0xFF, 0xFF, 0xFF, 0x07,
    ];
}
