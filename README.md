# EasyVideoTrimmer

![Image of basic concept](https://blogdownloads.blob.core.windows.net/githubhost/BasicDiagram1.jpg)

## Purpose

Simple, quick, video trimmer / converter GUI application. Load your video clip, select a time range, and export to disk. Tool is meant to be simple, and has very few features. There are other video trimmers/converters our there that have more features, but this is designed to be quick.

## Core Requirements

* Ability to load a video clip into the application to play/seek/preview video
* Ability to set a time range within the clip that will be exported
* Ability to export the selected time range to a new file on disk ( file name of users choosing )
* Ability to change the bitrate of the video export
* Ability to change the pixel dimensions of the video to export

## Technologies used

### Code/Solution

I will initially target .net 5.0 ( or .net 6.0 preview because of MAUI ) because it is the new unified platform that Microsoft is on the journey towards and I have not yet built a project using it, however if there are library issues I may need to revert to .net framework.

### Transcode/Convert/Trimming library

I have used FFMPEG before, so I plan to use FFMPEG library which I know can handle these basic requirements with room for more advanced features in the future.

How the FFMPEG library integrates into the application is currently unknown and to be discovered. Will the application execute a process of ffmpeg e.g. passing in arguments? Or is there code libraries available within .net that allow native method calls to the ffmpeg library.

## Targetting Framework

Most of my easy video trimmer needs are for Windows OS, so I will primarily be building the application to target a Windows OS. Although if the opportunity arises, I will see what I can do to target more than one platform ( sometimes I use Mac for trimming videos ).
