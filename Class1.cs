/*
 * todo: set Properties > Debug > Start Action to tModLoader Terraria.exe
 * todo: set Properties > Debug > Working directory to Terraria folder
 * todo: update description.txt
 */

using System;
using Terraria;
using Terraria.ModLoader;

namespace $safeprojectname$ {
    class $safeprojectname$ : Mod {
        public $safeprojectname$() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            }
        }
    }
}
