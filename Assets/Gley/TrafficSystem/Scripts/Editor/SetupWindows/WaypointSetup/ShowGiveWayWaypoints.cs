﻿using Gley.UrbanSystem.Editor;
using UnityEngine;

namespace Gley.TrafficSystem.Editor
{
    public class ShowGiveWayWaypoints : ShowWaypointsTrafficBase
    {
        private readonly float _scrollAdjustment = 221;

        public override SetupWindowBase Initialize(WindowProperties windowProperties, SettingsWindowBase window)
        {
            base.Initialize(windowProperties, window);
            _waypointsOfInterest = _trafficWaypointData.GetGiveWayWaypoints();
            return this;
        }

        public override void DrawInScene()
        {
            _trafficWaypointDrawer.ShowGiveWayWaypoints(_editorSave.EditorColors.WaypointColor);
            base.DrawInScene();
        }

        protected override void ScrollPart(float width, float height)
        {
            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition, false, false, GUILayout.Width(width - SCROLL_SPACE), GUILayout.Height(height - _scrollAdjustment));
            base.ScrollPart(width, height);
            GUILayout.EndScrollView();
        }
    }
}