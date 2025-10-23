using System;
using System.Collections.Generic;
using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.Unturned.Player;
using Rocket.Unturned.Chat;
using UnityEngine;

using Logger = Rocket.Core.Logging.Logger;

namespace RoxesKopyala
{
    public class RoxesKopyalaConfiguration : IRocketPluginConfiguration
    {
        public void LoadDefaults() { }
    }

    public class RoxesKopyala : RocketPlugin<RoxesKopyalaConfiguration>
    {
        public static RoxesKopyala Instance { get; private set; }

        protected override void Load()
        {
            Instance = this;
            Logger.Log("RoxesKopyala eklentisi yüklendi.", ConsoleColor.Green);
        }

        protected override void Unload()
        {
            Instance = null;
            Logger.Log("RoxesKopyala kaldırıldı.", ConsoleColor.Yellow);
        }
    }

    public class CopyCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "kopyala";
        public string Help => "Mevcut koordinatlarınızı gösterir.";
        public string Syntax => "";
        public List<string> Aliases => new List<string>() { "konum" };
        public List<string> Permissions => new List<string>() { "kopyala.use" };

        private UnityEngine.Color ToUnityColor(System.Drawing.Color systemColor)
        {
            return new UnityEngine.Color(
                systemColor.R / 255f,
                systemColor.G / 255f,
                systemColor.B / 255f
            );
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var uPlayer = (UnturnedPlayer)caller;
            var position = uPlayer.Player.transform.position;

            string x = position.x.ToString("F2");
            string y = position.y.ToString("F2");
            string z = position.z.ToString("F2");

            string formattedCoords = $"X: {x} | Y: {y} | Z: {z}";
            string tpFormat = $"{x} {y} {z}";

            UnturnedChat.Say(uPlayer, "[RoxesKopyala] Koordinatlarınız:", ToUnityColor(System.Drawing.Color.Aqua));
            UnturnedChat.Say(uPlayer, formattedCoords, ToUnityColor(System.Drawing.Color.Yellow));
            UnturnedChat.Say(uPlayer, $"Işınlanma Formatı: {tpFormat}", ToUnityColor(System.Drawing.Color.Gray));
        }
    }
}
