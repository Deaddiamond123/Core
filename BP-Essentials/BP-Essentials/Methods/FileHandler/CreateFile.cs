﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using static BP_Essentials.EssentialsVariablesPlugin;
using static BP_Essentials.EssentialsMethodsPlugin;
using System.IO;

namespace BP_Essentials
{
    class CreateFile : EssentialsChatPlugin
    {
        public static void Run(string fileName)
        {
            try
            {
                switch (fileName)
                {
                    case SettingsFile:
                        {
                            string[] content = { "# ---------------------------------------------------------------------------------------- #", "#                             Broke Protocol: Essentials                                   #", "#                        Created by UserR00T and DeathByKorea and BP                       #", "# ---------------------------------------------------------------------------------------- #", "#                                                                                          #", "#                                                                                          #", "#                                                                                          #", "# NOTE:                                                                                    #", "# CommandCharacter will be automatically added to the commands! No need to do that!        #", "# Example:                                                                                 #", "# INCORRECT: ClearChatCommand: /clearchat                                                  #", "# CORRECT: ClearChatCommand: clearchat                                                     #", "# if CommandCharacter is / it will automatically add a /                                   #", "#                                                                                          #", "# ---------------------------------------------------------------------------------------- #", "", "", "", "", "", "#----------------------------------------------------------#", "#                           General                        #", "#----------------------------------------------------------#", "version: " + EssentialsVariablesPlugin.Version, "", "# Character used for commands", "#----------------------------------", "CommandCharacter: /", "", @"# Will display ""unknown command"" if the command is not found in this plugin", "#----------------------------------", "UnknownCommand: true", "", "noperm: No permission.", "", "", "", "", "", "#----------------------------------------------------------#", "#                          Commands                        #", "#----------------------------------------------------------#", "", "# Reload command", "#----------------------------------", "ReloadCommand: reload", "ReloadCommand2: rl", "", "# Clearchat command", "#----------------------------------", "ClearChatCommand: clearchat", "ClearChatCommand2: cc", "", "# Say command", "#----------------------------------", "SayCommand: say", "SayCommand2: broadcast", "", "# CheckIP/Player command", "#----------------------------------", "CheckIPCommand: checkip", "CheckPlayerCommand: checkplayer", "", "# Fake Join/Leave command", "#----------------------------------", "FakeLeaveCommand: fakeleave", "FakeJoinCommand: fakejoin", "", "# Player info command", "#----------------------------------", "InfoPlayerCommand: info", "InfoPlayerCommand2: stats", "", "# Money command", "#----------------------------------", "MoneyCommand: money", "MoneyCommand2: setbal", "", "# Rules command", "#----------------------------------", "RulesCommand: rules", "", "", "# Discord command", "#----------------------------------", "DiscordCommand: discord", "", "# Online Players command", "#----------------------------------", "PlayersOnlineCommand: players", "PlayersOnlineCommand2: online", "", "# Godmode command --- Godmode default saving location - 'godmode.txt'", "#----------------------------------", "GodmodeCommand: god", "GodmodeCommand2: godmode", "", "# AFK command --- AFK default saving location - 'afkplayers.txt'", "#----------------------------------", "AFKCommand: afk", "AFKCommand2: brb", "", "# Mute command --- Mute default saving location - 'muteplayers.txt'", "#----------------------------------", "MuteCommand: mute", "# Unmute Command", "UnMuteCommand: unmute", "", "# ATM command", "#----------------------------------", "ATMCommand: atm", "", "", "", "#----------------------------------------------------------#", "#                          Messages                        #", "#----------------------------------------------------------#", "# Say prefix: Will show the string infront of the message", "# Example: [!!!] UserR00T: This is a message!", "# A space is not required at the end.", "#----------------------------------", "msgSayPrefix: [!!!]", "", "# Discord invite link", "#----------------------------------", "DiscordLink: https://discord.gg/Test", "", "", "", "#----------------------------------------------------------#", "#                    Additional Settings                   #", "#----------------------------------------------------------#", "", "", "# ChatBlock --- Words default location - 'chatblock.txt'", "# Enable chatblock", "#----------------------------------", "enableChatBlock: true", "", "", "# LanguageBlock --- Words default location - 'languageblock.txt'", "# Enable LanguageBlock", "#----------------------------------", "enableLanguageBlock: true", "", "# Enable ATM command", "#----------------------------------", "EnableATMCommand: true", "", "# This will check for alt accounts with the same IP.", "# NOTE: If someone in the same home connects with the same IP it will be detected as alt.", "# Enable CheckForAlts", "#----------------------------------", "CheckForAlts: true", "", "", "# Seconds between annoucements in seconds -- Announcements in 'Annoucements.txt'", "#----------------------------------", "TimeBetweenAnnounce: 360", "", "", "# TimestampFormat; This means what you will see infront of a message: ", "# E.g: [{H}:{M}:{S}] and your time is 12:05:59 it will show [12:05:59]", "# E.g Time/Date:                                 | [Year] [Month] [Day] [Hour] [Minute] [Second] [AM/PM]", "#                                                |  2017    9       22    22     18        6        PM", "# Placeholders:", "# {YYYY} Year                                    |  2017", "# {MM} Month (2 numbers)                         |          9", "# {MMMM} Month (full name)                       |        September", "# {DD} Day (2 numbers)                           |                  22", "# {DDDD} Day (full name)                         |                Friday", "# {H} Hours (24 hour clock)                      |                        22", "# {h} Hours (12 hour clock)                      |                        10", "# {M} Minutes                                    |                               18", "# {S} Seconds                                    |                                         6", "# {T} AM/PM (used in {h} 12 hour clock)          |                                                  PM", "# So, this would be:", "# [{YYYY}:{MM}:{DD}] [{H}:{M}:{S}]", "# [2017:09:22] [22:18:06]", "#----------------------------------", "TimestapFormat: [{YYYY}:{MM}:{DD}] [{H}:{M}:{S}]" };
                            File.WriteAllLines(SettingsFile, content);
                            break;
                        }
                    case ChatBlockFile:
                        {
                            string[] content = { "nigger", "nigga", "nigg3r", "NIGGER", "NI99ER", "ni99er", "nigger.", "nigga.", "nigg3r.", "N199ER", "n1gger", "N1GGER", "NIGGA", "NIGGA." };
                            File.WriteAllLines(ChatBlockFile, content);
                            break;
                        }
                    case LanguageBlockFile:
                        {
                            string[] content = { "bombas", "hola", "alguien", "habla", "espanol", "español", "estoy", "banco", "voy", "consegi", "donde", "quedamos", "banko", "afuera", "estas", "alguem", "donde", "nos", "vemos", "soy ", "vueno", "como", "carro", "cabros", "miren", "hacha", "laar", "corri", "sacame", "aqui", "policia", "trajo", "encerro", "bomba", "beuno", "pantalones", "dinero", "porque", "tengo", "escopetaa", "escopeta" };
                            File.WriteAllLines(LanguageBlockFile, content);
                            break;
                        }
                    case CustomCommandsFile:
                        {
                            string[] content = { "# Custom commands file", "# Place your custom commands here", "#", "# Format:", "# Command: example", "# Respone: The time is {H}:{M}:{S}. ", "#", "# ", "# Placeholders:", "# ", "# Current time:", "# E.g Time/Date:                                 | [Year] [Month] [Day] [Hour] [Minute] [Second] [AM/PM]", "#                                                |  2017    9       22    22     18        6        PM", "# Placeholders:", "# {YYYY} Year                                    |  2017", "# {MM} Month (2 numbers)                         |          9", "# {MMMM} Month (full name)                       |        September", "# {DD} Day (2 numbers)                           |                  22", "# {DDDD} Day (full name)                         |                Friday", "# {H} Hours (24 hour clock)                      |                        22", "# {h} Hours (12 hour clock)                      |                        10", "# {M} Minutes                                    |                               18", "# {S} Seconds                                    |                                         6", "# {T} AM/PM (used in {h} 12 hour clock)          |                                                  PM", "# So, this would be:", "# [{YYYY}:{MM}:{DD}] [{H}:{M}:{S}]", "# [2017:09:22] [22:18:06]", "#", "# Player placeholders:", "# {username} Players username", "# ----------------------------------------------", "", "Command: servertime", "Response: The time on the server(pc) is: {YYYY}/{MM}/{DD}, {H}:{M}:{S}.", "", "Command: example", "Response: Your username is {username}!" };
                            File.WriteAllLines(CustomCommandsFile, content);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Run(ex);
            }
        }
    }
}