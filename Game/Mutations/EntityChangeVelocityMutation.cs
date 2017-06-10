﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IORPG.Game.Mutations
{
    public class EntityChangeVelocityMutation : IWorldMutation
    {
        public WorldMutationTime Time => WorldMutationTime.BeforeEntitiesTick;
        public int ID;
        public Vector2 NewVelocity;

        public EntityChangeVelocityMutation(int id, Vector2 newVel)
        {
            ID = id;
            NewVelocity = newVel;
        }

        public void Apply(MutatingWorld world)
        {
            var ind = world.Entities.FindIndex((en) => en.ID == ID);
            var e = world.Entities[ind];
            world.Entities[ind] = new Entity(e, velocity: NewVelocity);
        }
    }
}
