/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> This data type stores information about a scheduled update to an Auto Scaling group. </para>
    /// </summary>
    public class ScheduledUpdateGroupAction
    {
        
        private string autoScalingGroupName;
        private string scheduledActionName;
        private string scheduledActionARN;
        private DateTime? time;
        private DateTime? startTime;
        private DateTime? endTime;
        private string recurrence;
        private int? minSize;
        private int? maxSize;
        private int? desiredCapacity;


        /// <summary>
        /// The name of the Auto Scaling group to be updated.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The name of this scheduled action.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ScheduledActionName
        {
            get { return this.scheduledActionName; }
            set { this.scheduledActionName = value; }
        }

        // Check to see if ScheduledActionName property is set
        internal bool IsSetScheduledActionName()
        {
            return this.scheduledActionName != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of this scheduled action.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ScheduledActionARN
        {
            get { return this.scheduledActionARN; }
            set { this.scheduledActionARN = value; }
        }

        // Check to see if ScheduledActionARN property is set
        internal bool IsSetScheduledActionARN()
        {
            return this.scheduledActionARN != null;
        }

        /// <summary>
        /// <c>Time</c> is deprecated. The time that the action is scheduled to begin. <c>Time</c> is an alias for <c>StartTime</c>.
        ///  
        /// </summary>
        public DateTime Time
        {
            get { return this.time ?? default(DateTime); }
            set { this.time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this.time.HasValue;
        }

        /// <summary>
        /// The time that the action is scheduled to begin. This value can be up to one month in the future. When <c>StartTime</c> and <c>EndTime</c>
        /// are specified with <c>Recurrence</c>, they form the boundaries of when the recurring action will start and stop.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// The time that the action is scheduled to end. This value can be up to one month in the future.
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;
        }

        /// <summary>
        /// The regular schedule that an action occurs.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Recurrence
        {
            get { return this.recurrence; }
            set { this.recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this.recurrence != null;
        }

        /// <summary>
        /// The minimum size of the Auto Scaling group.
        ///  
        /// </summary>
        public int MinSize
        {
            get { return this.minSize ?? default(int); }
            set { this.minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this.minSize.HasValue;
        }

        /// <summary>
        /// The maximum size of the Auto Scaling group.
        ///  
        /// </summary>
        public int MaxSize
        {
            get { return this.maxSize ?? default(int); }
            set { this.maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this.maxSize.HasValue;
        }

        /// <summary>
        /// The number of instances you prefer to maintain in your Auto Scaling group.
        ///  
        /// </summary>
        public int DesiredCapacity
        {
            get { return this.desiredCapacity ?? default(int); }
            set { this.desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this.desiredCapacity.HasValue;
        }
    }
}
