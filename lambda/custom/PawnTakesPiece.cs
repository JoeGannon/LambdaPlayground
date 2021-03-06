﻿namespace sampleFactCsharp
{
    using AlexaAPI.Request;

    public class PawnTakesPiece : EchoIntent
    {
        public string Name => "PawnTakesPiece";

        public string AlgebraicMove(Intent intent)
        {
            intent.Slots.TryGetValue("Pawn", out var pawn);
            intent.Slots.TryGetValue("Square", out var square);
            pawn.Value = pawn.Value.Replace(".", "");

            var text = pawn.Value.ToLower() + "x" + square.Value.ToSquare();


            return text;
        }

        public string SpokenMove(Intent intent)
        {
            intent.Slots.TryGetValue("Pawn", out var pawn);
            intent.Slots.TryGetValue("Square", out var square);
            pawn.Value = pawn.Value.Replace(".", "");

            var text = pawn.Value.ToLower() + " takes " + square.Value.ToSquare();


            return text;
        }
    }
}