using System;
using Cosmos;
using scr = Hattory.Kernel;

namespace txtxtx
{
    public class Font8x8
    {
        /*{
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };
        */

    //7x13
    public static Byte[] Dote = { 
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            1, 1, 1, 0, 0, 0, 0,
            1, 1, 1, 0, 0, 0, 0,
            1, 1, 1, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] NotF = { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };

        public static Byte[] Utro = { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] Fill = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        public static Byte[] zapapa = { 
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 1, 1, 0, 0, 0, 0,
            0, 1, 1, 0, 0, 0, 0,
            0, 0, 1, 0, 0, 0, 0,
            0, 0, 1, 0, 0, 0, 0,
            0, 1, 0, 0, 0, 0, 0 };

        public static Byte[] kov = { 
            0, 1, 1, 0, 1, 1, 0,
            0, 1, 1, 0, 1, 1, 0,
            0, 1, 1, 0, 1, 1, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] vopros = {
            0, 0, 0, 1, 0, 0, 0,
            0, 0, 1, 1, 1, 0, 0,
            0, 1, 1, 0, 1, 1, 0,
            1, 1, 0, 0, 0, 1, 1,
            0, 0, 0, 0, 0, 1, 1,
            0, 0, 0, 0, 1, 1, 0,
            0, 0, 0, 0, 1, 1, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };


        public static Byte[] sobaka = {
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] resh = {
            0, 1, 0, 1, 0,
            0, 1, 0, 1, 0,
            1, 1, 1, 1, 1,
            0, 1, 0, 1, 0,
            0, 1, 0, 1, 0,
            1, 1, 1, 1, 1,
            0, 1, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] dollar = {
            0, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 1, 0, 0,};

        public static Byte[] xyi = {
            0, 0, 1, 0, 0,
            0, 1, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] andd = {
            0, 0, 1, 0, 0,
            0, 1, 0, 1, 0,
            1, 0, 0, 1, 0,
            1, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 1, 0, 1,
            1, 0, 0, 1, 0,
            0, 1, 1, 0, 1,
            0, 0, 0, 0, 0 };

        public static Byte[] zvezda = {
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 1, 1, 1, 0,
            1, 1, 1, 1, 1,
            0, 1, 1, 1, 0,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Sopen = {
            0, 1, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Sclose = {
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] procent = {
            1, 1, 1, 0, 0,
            1, 0, 1, 0, 0,
            1, 1, 1, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 1, 1, 1,
            0, 0, 1, 0, 1,
            0, 0, 1, 1, 1 };

        public static Byte[] defis = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] loll = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            1, 1, 1, 1, 1 };

        public static Byte[] CapA = { 
            1, 0, 0, 0, 0,
            1, 1, 0, 0, 0,
            1, 0, 1, 0, 0,
            1, 0, 0, 1, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlA = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 1, 1,
            0, 1, 1, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapB = { 
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlB = { 
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapC = { 
            0, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlC = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapD = { 
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlD = { 
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 1, 1, 1, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapE = { 
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlE = { 
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            0, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapF = { 
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlF = { 
            0, 0, 0, 1, 1,
            0, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapG = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 1, 1, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlG = { 
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0 };

        public static Byte[] CapH = { 
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlH = { 
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapI = { 
            1, 1, 1, 1, 1,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlI = { 
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapJ = { 
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlJ = { 
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 1, 0,
            0, 1, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapK = { 
            1, 0, 0, 1, 0,
            1, 0, 1, 0, 0,
            1, 1, 0, 0, 0,
            1, 0, 1, 0, 0,
            1, 0, 0, 1, 0,
            1, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlK = { 
            1, 0, 1, 0, 0,
            1, 0, 1, 0, 0,
            1, 1, 0, 0, 0,
            1, 0, 1, 0, 0,
            1, 0, 0, 1, 0,
            1, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapL = { 
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlL = { 
            0, 0, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapM = { 
            1, 0, 0, 0, 1,
            1, 1, 0, 1, 1,
            1, 0, 1, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlM = { 
            0, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 0, 1, 0,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };
        //
        public static Byte[] CapN = {
        1, 1, 0, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 0, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlN = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapO = {
         0, 1, 1, 1, 0,
         1, 0, 0, 0, 1,
         1, 0, 0, 0, 1,
         1, 0, 0, 0, 1,
         1, 0, 0, 0, 1,
         0, 1, 1, 1, 0,
         0, 0, 0, 0, 0,
         0, 0, 0, 0, 0,
         0, 0, 0, 0, 0 };

        public static Byte[] SmlO = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapP = {
        1, 1, 1, 1, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 1, 1, 1, 0,
        1, 0, 0, 0, 0,
        1, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlP = {
        0, 0, 0, 0, 0,
        1, 1, 1, 0, 0,
        1, 0, 0, 1, 0,
        1, 0, 0, 1, 0,
        1, 1, 1, 0, 0,
        1, 0, 0, 0, 0,
        1, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,};

        public static Byte[] CapQ = {
        1, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 0, 1, 0,
        0, 0, 0, 1, 0,
        0, 0, 0, 0, 1,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlQ = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 1, 1,
        0, 0, 0, 0, 1,
        0, 0, 0, 0, 0 };

        public static Byte[] CapR = {
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 1, 1, 1, 0,
        1, 0, 1, 0, 0,
        1, 0, 0, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlR = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 1, 1, 0, 0,
        1, 0, 0, 1, 0,
        1, 0, 0, 0, 0,
        1, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapS = {
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlS = {
        0, 0, 0, 0, 0,
        0, 1, 1, 1, 1,
        1, 0, 0, 0, 0,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 1,
        1, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapT = {
        0, 1, 1, 1, 0,
        1, 0, 1, 0, 1,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlT = {
        0, 1, 0, 0, 0,
        1, 1, 1, 0, 0,
        0, 1, 0, 0, 0,
        0, 1, 0, 0, 0,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapU = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlU = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapV = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlV = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapW = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlW = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapX = {
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 1, 0, 1, 0,
        1, 0, 0, 0, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlX = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 1, 0, 1, 1,
        0, 0, 1, 1, 0,
        0, 0, 1, 0, 0,
        1, 1, 0, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapY = {
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlY = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 0, 1,
        0, 0, 1, 1, 1,
        0, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapZ = {
        1, 1, 1, 1, 1,
        0, 0, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 1, 0, 0, 0,
        1, 0, 0, 0, 0,
        1, 1, 1, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlZ = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 1, 1, 1, 1,
        0, 0, 0, 1, 0,
        0, 0, 1, 0, 0,
        1, 1, 1, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] Null = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Zero = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] One = { 
            0, 1, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Two = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Three = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 0, 1, 1, 0,
            0, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Four = { 
            0, 0, 0, 1, 0,
            0, 0, 1, 1, 0,
            0, 1, 0, 1, 0,
            1, 0, 0, 1, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Five = { 
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Six = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 1, 1, 0,
            1, 1, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Seven = { 
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] slash = {
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 0, 0, 0 };

        public static Byte[] neslash = {
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 0, 0, 0,
            0, 1, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 1 };

        public static Byte[] palka = {
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0 };

        public static Byte[] plus = {
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] ravno = {
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Eight = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] Nine = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] Colon = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
    public static class FontDrawer
    {
        public static void DrawTextChar(int x, int y, byte[] Data, System.Drawing.Color Color)
        {
            int c = 0;
            for (int p = y; p < y + 9; p++)
            {
                for (int i = x; i < x + 5; i++)
                {
                    if (Data[c] == 1)
                    {
                        scr.canvas.DrawPoint(Color, i, p);
                    }

                    c = c + 1;
                }
            }
        }
        public static void WriteText(String Text, int Textx, int Texty, System.Drawing.Color Color, bool NTDF = false)
        {
            int iznx = Textx;
            if (NTDF == true) {
                foreach (char a in Text)
                {
                    if (a == 'A')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapA, Color);
                        Textx += 6;
                    }
                    else if (a == 'a')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlA, Color);
                        Textx += 6;
                    }
                    else if (a == 'B')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapB, Color);
                        Textx += 6;
                    }
                    else if (a == 'b')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlB, Color);
                        Textx += 6;
                    }
                    else if (a == 'C')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapC, Color);
                        Textx += 6;
                    }
                    else if (a == 'c')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlC, Color);
                        Textx += 6;
                    }
                    else if (a == 'D')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapD, Color);
                        Textx += 6;
                    }
                    else if (a == 'd')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlD, Color);
                        Textx += 6;
                    }

                    else if (a == 'E')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapE, Color);
                        Textx += 6;
                    }
                    else if (a == 'e')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlE, Color);
                        Textx += 6;
                    }
                    else if (a == 'F')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapF, Color);
                        Textx += 6;
                    }
                    else if (a == 'f')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlF, Color);
                        Textx += 6;
                    }
                    else if (a == 'G')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapG, Color);
                        Textx += 6;
                    }
                    else if (a == 'g')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlG, Color);
                        Textx += 6;
                    }
                    else if (a == 'H')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapH, Color);
                        Textx += 6;
                    }
                    else if (a == 'h')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlH, Color);
                        Textx += 6;
                    }
                    else if (a == 'I')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapI, Color);
                        Textx += 6;
                    }
                    else if (a == 'i')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlI, Color);
                        Textx += 6;
                    }
                    else if (a == 'J')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapJ, Color);
                        Textx += 6;
                    }
                    else if (a == 'j')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlJ, Color);
                        Textx += 6;
                    }

                    else if (a == 'K')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapK, Color);
                        Textx += 6;
                    }
                    else if (a == 'k')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlK, Color);
                        Textx += 6;
                    }
                    else if (a == 'L')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapL, Color);
                        Textx += 6;
                    }
                    else if (a == 'l')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlL, Color);
                        Textx += 6;
                    }
                    else if (a == 'M')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapM, Color);
                        Textx += 6;
                    }
                    else if (a == 'm')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlM, Color);
                        Textx += 6;
                    }
                    else if (a == 'N')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapN, Color);
                        Textx += 6;
                    }
                    else if (a == 'n')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlN, Color);
                        Textx += 6;
                    }
                    else if (a == 'O')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapO, Color);
                        Textx += 6;
                    }
                    else if (a == 'o')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlO, Color);
                        Textx += 6;
                    }
                    else if (a == 'P')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapP, Color);
                        Textx += 6;
                    }
                    else if (a == 'p')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlP, Color);
                        Textx += 6;
                    }

                    else if (a == 'Q')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapQ, Color);
                        Textx += 6;
                    }
                    else if (a == 'q')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlQ, Color);
                        Textx += 6;
                    }
                    else if (a == 'R')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapR, Color);
                        Textx += 6;
                    }
                    else if (a == 'r')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlR, Color);
                        Textx += 6;
                    }
                    else if (a == 'S')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapS, Color);
                        Textx += 6;
                    }
                    else if (a == 's')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlS, Color);
                        Textx += 6;
                    }
                    else if (a == 'T')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapT, Color);
                        Textx += 6;
                    }
                    else if (a == 't')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlT, Color);
                        Textx += 6;
                    }
                    else if (a == 'U')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapU, Color);
                        Textx += 6;
                    }
                    else if (a == 'u')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlU, Color);
                        Textx += 6;
                    }
                    else if (a == 'V')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapV, Color);
                        Textx += 6;
                    }
                    else if (a == 'v')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlV, Color);
                        Textx += 6;
                    }

                    else if (a == 'W')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapW, Color);
                        Textx += 6;
                    }
                    else if (a == 'w')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlW, Color);
                        Textx += 6;
                    }
                    else if (a == 'X')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapX, Color);
                        Textx += 6;
                    }
                    else if (a == 'x')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlX, Color);
                        Textx += 6;
                    }
                    else if (a == 'Y')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapY, Color);
                        Textx += 6;
                    }
                    else if (a == 'y')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlY, Color);
                        Textx += 6;
                    }
                    else if (a == 'Z')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.CapZ, Color);
                        Textx += 6;
                    }
                    else if (a == 'z')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.SmlZ, Color);
                        Textx += 6;
                    }
                    else if (a == '.')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Dote, Color);
                        Textx += 6;
                    }
                    else if (a == '!')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Utro, Color);
                        Textx += 6;
                    }
                    else if (a == ' ')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Null, Color);
                        Textx += 6;
                    }
                    else if (a == '0')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Zero, Color);
                        Textx += 6;
                    }
                    else if (a == '1')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.One, Color);
                        Textx += 6;
                    }
                    else if (a == '2')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Two, Color);
                        Textx += 6;
                    }
                    else if (a == '3')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Three, Color);
                        Textx += 6;
                    }
                    else if (a == '4')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Four, Color);
                        Textx += 6;
                    }
                    else if (a == '5')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Five, Color);
                        Textx += 6;
                    }
                    else if (a == '6')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Six, Color);
                        Textx += 6;
                    }
                    else if (a == '7')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Seven, Color);
                        Textx += 6;
                    }
                    else if (a == '8')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Eight, Color);
                        Textx += 6;
                    }
                    else if (a == '9')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Nine, Color);
                        Textx += 6;
                    }
                    else if (a == ':')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Colon, Color);
                        Textx += 6;
                    }
                    else if (a == '[')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Fill, Color);
                        Textx += 6;
                    }
                    else if (a == ']')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.NotF, Color);
                        Textx += 6;
                    }
                    else if (a == '_')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.loll, Color);
                        Textx += 6;
                    }
                    else if (a == '-')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.defis, Color);
                        Textx = Textx + 4;
                    }
                    else if (a == '|')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.palka, Color);
                        Textx += 6;
                    }
                    else if (a == '/')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.slash, Color);
                        Textx += 6;
                    }
                    else if (a == '\\')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.neslash, Color);
                        Textx += 6;
                    }
                    else if (a == '=')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.ravno, Color);
                        Textx += 6;
                    }
                    else if (a == '+')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.plus, Color);
                        Textx += 6;
                    }
                    else if (a == '%')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.procent, Color);
                        Textx += 6;
                    }
                    else if (a == '@')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.sobaka, Color);
                        Textx += 6;
                    }
                    else if (a == '?')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.vopros, Color);
                        Textx += 6;
                    }
                    else if (a == '#')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.resh, Color);
                        Textx += 6;
                    }
                    else if (a == '$')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.dollar, Color);
                        Textx += 6;
                    }
                    else if (a == '^')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.xyi, Color);
                        Textx += 6;
                    }
                    else if (a == '&')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.andd, Color);
                        Textx += 6;
                    }
                    else if (a == '*')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.zvezda, Color);
                        Textx += 6;
                    }
                    else if (a == '(')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Sopen, Color);
                        Textx += 6;
                    }
                    else if (a == ')')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.Sclose, Color);
                        Textx += 6;
                    }
                    else if (a == '\'')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.kov, Color);
                        Textx += 6;
                    }
                    else if (a == ',')
                    {
                        DrawTextChar(Textx, Texty, Font8x8.zapapa, Color);
                        Textx += 6;
                    }
                    else if (a == '`')
                    {
                        //DrawTextChar(Textx, Texty, Font8x8.nul, Color);
                        Textx = iznx;
                        Texty += 11;
                    }
                }
            }
            else
            {
                Hattory.Kernel.canvas.DrawString(Text, Cosmos.System.Graphics.Fonts.PCScreenFont.Default, Color, Textx, Texty);
            }
        }
    }        
}
