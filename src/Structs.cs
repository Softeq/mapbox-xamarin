﻿using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace Mapbox
{
    [Native]
    public enum MGLAnnotationViewDragState : ulong
    {
        None = 0,
        Starting,
        Dragging,
        Canceling,
        Ending
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLCoordinateSpan
    {
        public double latitudeDelta;

        public double longitudeDelta;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLMapPoint
    {
        public nfloat x;

        public nfloat y;

        public nfloat zoomLevel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLMatrix4
    {
        public double m00;

        public double m01;

        public double m02;

        public double m03;

        public double m10;

        public double m11;

        public double m12;

        public double m13;

        public double m20;

        public double m21;

        public double m22;

        public double m23;

        public double m30;

        public double m31;

        public double m32;

        public double m33;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLCoordinateBounds
    {
        public CLLocationCoordinate2D sw;

        public CLLocationCoordinate2D ne;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLCoordinateQuad
    {
        public CLLocationCoordinate2D topLeft;

        public CLLocationCoordinate2D bottomLeft;

        public CLLocationCoordinate2D bottomRight;

        public CLLocationCoordinate2D topRight;
    }

    [Native]
    public enum MGLErrorCode : long
    {
        Unknown = -1,
        NotFound = 1,
        BadServerResponse = 2,
        ConnectionFailed = 3,
        ParseStyleFailed = 4,
        LoadStyleFailed = 5,
        SnapshotFailed = 6,
        SourceIsInUseCannotRemove = 7,
        SourceIdentifierMismatch = 8
    }

    [Native]
    public enum MGLMapDebugMaskOptions : ulong
    {
        TileBoundariesMask = 1 << 1,
        TileInfoMask = 1 << 2,
        TimestampsMask = 1 << 3,
        CollisionBoxesMask = 1 << 4,
        OverdrawVisualizationMask = 1 << 5
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLTransition
    {
        public double duration;

        public double delay;
    }

    [Native]
    public enum MGLLightAnchor : ulong
    {
        Map,
        Viewport
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLSphericalPosition
    {
        public nfloat radial;

        public double azimuthal;

        public double polar;
    }

    [Native]
    public enum MGLAnnotationVerticalAlignment : ulong
    {
        Center = 0,
        Top,
        Bottom
    }

    [Native]
    public enum MGLOrnamentPosition : ulong
    {
        TopLeft = 0,
        TopRight,
        BottomLeft,
        BottomRight
    }

    [Native]
    public enum MGLUserTrackingMode : ulong
    {
        None = 0,
        Follow,
        FollowWithHeading,
        FollowWithCourse
    }

    [Native]
    public enum MGLCameraChangeReason : ulong
    {
        None = 0,
        Programmatic = 1 << 0,
        ResetNorth = 1 << 1,
        GesturePan = 1 << 2,
        GesturePinch = 1 << 3,
        GestureRotate = 1 << 4,
        GestureZoomIn = 1 << 5,
        GestureZoomOut = 1 << 6,
        GestureOneFingerZoom = 1 << 7,
        GestureTilt = 1 << 8,
        TransitionCancelled = 1 << 16
    }

    [Native]
    public enum MGLOfflinePackState : long
    {
        Unknown = 0,
        Inactive = 1,
        Active = 2,
        Complete = 3,
        Invalid = 4
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLOfflinePackProgress
    {
        public ulong countOfResourcesCompleted;

        public ulong countOfBytesCompleted;

        public ulong countOfTilesCompleted;

        public ulong countOfTileBytesCompleted;

        public ulong countOfResourcesExpected;

        public ulong maximumResourcesExpected;
    }

    [Native]
    public enum MGLResourceKind : ulong
    {
        Unknown,
        Style,
        Source,
        Tile,
        Glyphs,
        SpriteImage,
        SpriteJSON,
        Image
    }

    [Native]
    public enum MGLFillExtrusionTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLFillTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLLineCap : ulong
    {
        Butt,
        Round,
        Square
    }

    [Native]
    public enum MGLLineJoin : ulong
    {
        Bevel,
        Round,
        Miter
    }

    [Native]
    public enum MGLLineTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLIconAnchor : ulong
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

    [Native]
    public enum MGLIconPitchAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLIconRotationAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLIconTextFit : ulong
    {
        None,
        Width,
        Height,
        Both
    }

    [Native]
    public enum MGLSymbolPlacement : ulong
    {
        Point,
        Line,
        LineCenter
    }

    [Native]
    public enum MGLSymbolZOrder : ulong
    {
        Auto,
        ViewportY,
        Source
    }

    [Native]
    public enum MGLTextAnchor : ulong
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }

    [Native]
    public enum MGLTextJustification : ulong
    {
        Auto,
        Left,
        Center,
        Right
    }

    [Native]
    public enum MGLTextPitchAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLTextRotationAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLTextTransform : ulong
    {
        None,
        Uppercase,
        Lowercase
    }

    [Native]
    public enum MGLIconTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLTextTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLRasterResamplingMode : ulong
    {
        Linear,
        Nearest
    }

    [Native]
    public enum MGLCirclePitchAlignment : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLCircleScaleAlignment : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLCircleTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLHillshadeIlluminationAnchor : ulong
    {
        Map,
        Viewport
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MGLStyleLayerDrawingContext
    {
        public CGSize size;

        public CLLocationCoordinate2D centerCoordinate;

        public double zoomLevel;

        public double direction;

        public nfloat pitch;

        public nfloat fieldOfView;

        public MGLMatrix4 projectionMatrix;
    }

    [Native]
    public enum MGLTileCoordinateSystem : ulong
    {
        Xyz = 0,
        Tms
    }

    [Native]
    public enum MGLDEMEncoding : ulong
    {
        Mapbox = 0,
        Terrarium
    }

    [Native]
    public enum MGLAttributionInfoStyle : ulong
    {
        Short = 1,
        Medium,
        Long
    }

    [Native]
    public enum MGLLoggingLevel : long
    {
        None = 0,
        Info,
        Debug,
        Error,
        Fault
    }

    [Native]
    public enum MGLMetricType : ulong
    {
        MGLMetricTypePerformance = 0
    }

    [Native]
    public enum MGLMapViewPreferredFramesPerSecond : long
    {
        Default,
        LowPower,
        Maximum
    }
}