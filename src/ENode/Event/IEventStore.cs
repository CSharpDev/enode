﻿using System;
using System.Collections.Generic;

namespace ENode.Eventing
{
    /// <summary>Represents a event store to store event streams of aggregate.
    /// </summary>
    public interface IEventStore
    {
        /// <summary>Append the event stream to the event store.
        /// </summary>
        void Append(EventStream stream);
        /// <summary>Check whether an event stream is exist.
        /// </summary>
        /// <param name="aggregateRootId"></param>
        /// <param name="aggregateRootType"></param>
        /// <param name="id"></param>
        /// <param name="commandId"></param>
        /// <returns></returns>
        bool IsEventStreamExist(string aggregateRootId, Type aggregateRootType, Guid id, Guid commandId);
        /// <summary>Query event streams from event store.
        /// </summary>
        IEnumerable<EventStream> Query(string aggregateRootId, Type aggregateRootType, long minStreamVersion, long maxStreamVersion);
        /// <summary>Query all the event streams from the event store.
        /// </summary>
        /// <returns></returns>
        IEnumerable<EventStream> QueryAll();
    }
}
