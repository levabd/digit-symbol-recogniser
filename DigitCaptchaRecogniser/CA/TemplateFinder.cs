//
//  THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//  PURPOSE.
//
//  License: GNU General Public License version 3 (GPLv3)
//
//  Email: pavel_torgashov@mail.ru.
//
//  Copyright (C) Pavel Torgashov, 2011. 

using System;

namespace ContourAnalysisNS
{
    public class TemplateFinder
    {
        public double minACF = 0.96d;
        public double minICF = 0.85d;
        public bool checkICF = true;
        public bool checkACF = true;
        public double maxRotateAngle = Math.PI;
        public double maxRotateAngleForOneAndSeven = Math.PI / 49;
        public double maxACFDescriptorDeviation = 4;
        public double maxACFDescriptorDeviation0 = 4;
        public double maxACFDescriptorDeviation1 = 4;
        public double maxACFDescriptorDeviation2 = 4;
        public double maxACFDescriptorDeviation3 = 4;
        public double maxACFDescriptorDeviation4 = 4;
        public double maxACFDescriptorDeviation5 = 4;
        public double maxACFDescriptorDeviation6 = 4;
        public double maxACFDescriptorDeviation7 = 4;
        public double maxACFDescriptorDeviation8 = 4;
        public double maxACFDescriptorDeviation9 = 4;
        public double maxACFNormaDeviation = 1;
        public double maxACFNormaDeviation0 = 1;
        public double maxACFNormaDeviation1 = 1;
        public double maxACFNormaDeviation2 = 1;
        public double maxACFNormaDeviation3 = 1;
        public double maxACFNormaDeviation4 = 1;
        public double maxACFNormaDeviation5 = 1;
        public double maxACFNormaDeviation6 = 1;
        public double maxACFNormaDeviation7 = 1;
        public double maxACFNormaDeviation8 = 1;
        public double maxACFNormaDeviation9 = 1;
        public string antiPatternName = "antipattern";

        public FoundTemplateDesc FindTemplate(Templates templates, Template sample)
        {
            //int maxInterCorrelationShift = (int)(templateSize * maxRotateAngle / Math.PI);
            //maxInterCorrelationShift = Math.Min(templateSize, maxInterCorrelationShift+13);
            double rate = 0;
            double angle = 0;
            Complex interCorr = default(Complex);
            Template foundTemplate = null;
            int templateIndex = -1;
            foreach (var template in templates)
            {
                templateIndex++;
                //
                if (Math.Abs(sample.autoCorrDescriptor1 - template.autoCorrDescriptor1) > maxACFDescriptorDeviation) continue;
                if (Math.Abs(sample.autoCorrDescriptor2 - template.autoCorrDescriptor2) > maxACFDescriptorDeviation) continue;
                if (Math.Abs(sample.autoCorrDescriptor3 - template.autoCorrDescriptor3) > maxACFDescriptorDeviation) continue;
                if (Math.Abs(sample.autoCorrDescriptor4 - template.autoCorrDescriptor4) > maxACFDescriptorDeviation) continue;
                //
                double r = 0;
                if (checkACF)
                {
                    r = template.autoCorr.NormDot(sample.autoCorr).Norma;
                    if (r < minACF)
                        continue;
                }
                if (checkICF)
                {
                    interCorr = template.contour.InterCorrelation(sample.contour).FindMaxNorma();
                    r = interCorr.Norma / (template.contourNorma * sample.contourNorma);
                    if (r < minICF)
                        continue;
                    if (Math.Abs(interCorr.Angle) > maxRotateAngle)
                        continue;
                }
                if (template.preferredAngleNoMore90 && Math.Abs(interCorr.Angle) >= Math.PI / 2)
                    continue;//unsuitable angle
                //find max rate
                if (r >= rate)
                {
                    rate = r;
                    foundTemplate = template;
                    foundTemplate.index = templateIndex;
                    angle = interCorr.Angle;
                }
            }
            //ignore antipatterns
            if (foundTemplate != null && foundTemplate.name == antiPatternName)
                foundTemplate = null;
            //
            if (foundTemplate != null)
                return new FoundTemplateDesc() { template = foundTemplate, rate = rate, sample = sample, angle = angle };
            else
                return null;
        }

        public FoundTemplateDesc FindTemplateByNorma(Templates templates, Template sample, bool rather6 = false, bool rather8 = false, bool rather9 = false, bool rather0 = false)
        {
            //int maxInterCorrelationShift = (int)(templateSize * maxRotateAngle / Math.PI);
            //maxInterCorrelationShift = Math.Min(templateSize, maxInterCorrelationShift+13);
            double rate = 0;
            double angle = 0;
            Complex interCorr = default(Complex);
            Template foundTemplate = null;
            int templateIndex = -1;
            double maxDeviation = 0;
            double maxNormaDeviation = maxACFNormaDeviation;
            foreach (var template in templates)
            {
                templateIndex++;
                switch (template.name)
                {
                    case "0":
                        {
                            maxNormaDeviation = maxACFNormaDeviation0;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation0;
                            break;
                        }
                    case "1":
                        {
                            maxNormaDeviation = maxACFNormaDeviation1;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation1;
                            break;
                        }
                    case "2":
                        {
                            maxNormaDeviation = maxACFNormaDeviation2;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation2;
                            break;
                        }
                    case "3":
                        {
                            maxNormaDeviation = maxACFNormaDeviation3;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation3;
                            break;
                        }
                    case "4":
                        {
                            maxNormaDeviation = maxACFNormaDeviation4;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation4;
                            break;
                        }
                    case "5":
                        {
                            maxNormaDeviation = maxACFNormaDeviation5;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation5;
                            break;
                        }
                    case "6":
                        {
                            maxNormaDeviation = maxACFNormaDeviation6;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation6;
                            break;
                        }
                    case "7":
                        {
                            maxNormaDeviation = maxACFNormaDeviation7;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation7;
                            break;
                        }
                    case "8":
                        {
                            maxNormaDeviation = maxACFNormaDeviation8;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation8;
                            break;
                        }
                    case "9":
                        {
                            maxNormaDeviation = maxACFNormaDeviation9;
                            maxACFDescriptorDeviation = maxACFDescriptorDeviation9;
                            break;
                        }
                }

                bool notDetected = false;
                for (int i = 0; i < sample.autoCorr.Count; i++)
                {
                    maxDeviation = (Math.Abs(sample.autoCorr[i].Norma - template.autoCorr[i].Norma) >
                        maxDeviation) ? Math.Abs(sample.autoCorr[i].Norma - template.autoCorr[i].Norma) : maxDeviation;
                    notDetected = notDetected ||
                                  (Math.Abs(sample.autoCorr[i].Norma - template.autoCorr[i].Norma) >
                                   maxNormaDeviation);
                }

                if (notDetected) continue;

                //
                if (Math.Abs(sample.autoCorrDescriptor1 - template.autoCorrDescriptor1) > maxACFDescriptorDeviation) continue;
                if (Math.Abs(sample.autoCorrDescriptor2 - template.autoCorrDescriptor2) > maxACFDescriptorDeviation) continue;
                if (Math.Abs(sample.autoCorrDescriptor3 - template.autoCorrDescriptor3) > maxACFDescriptorDeviation) continue;
                if (Math.Abs(sample.autoCorrDescriptor4 - template.autoCorrDescriptor4) > maxACFDescriptorDeviation) continue;
                //

                double r = 0;
                if (checkACF)
                {
                    r = template.autoCorr.NormDot(sample.autoCorr).Norma;
                    if (r < minACF)
                        continue;
                }
                if (checkICF)
                {
                    interCorr = template.contour.InterCorrelation(sample.contour).FindMaxNorma();
                    r = interCorr.Norma / (template.contourNorma * sample.contourNorma);
                    if (r < minICF)
                        continue;
                    if (Math.Abs(interCorr.Angle) > maxRotateAngle)
                        continue;
                    if (((template.name == "7") || (template.name == "1")) && (Math.Abs(interCorr.Angle) > maxRotateAngleForOneAndSeven))
                        continue;
                }
                if (template.preferredAngleNoMore90 && Math.Abs(interCorr.Angle) >= Math.PI / 2)
                    continue;//unsuitable angle
                //find max rate
                if (r >= rate)
                {
                    rate = r;
                    foundTemplate = template;
                    foundTemplate.index = templateIndex;
                    angle = interCorr.Angle;

                    if ((foundTemplate.name == "6890") && (rather6 || rather8 || rather9 || rather0))
                    {
                        if (rather6)
                        {
                            foundTemplate.name = "6";
                        }
                        else if (rather8)
                        {
                            foundTemplate.name = "8";
                        }
                        else if (rather9)
                        {
                            foundTemplate.name = "9";
                        }
                        else //if (rather9) always true
                        {
                            foundTemplate.name = "0";
                        }
                    }
                }
            }
            //ignore antipatterns
            if (foundTemplate != null && foundTemplate.name == antiPatternName)
                foundTemplate = null;
            //
            if (foundTemplate != null)
                return new FoundTemplateDesc() { template = foundTemplate, rate = rate, sample = sample, angle = angle };
            else
                return null;
        }
    }

    public class FoundTemplateDesc
    {
        public double rate;
        public Template template;
        public Template sample;
        public double angle;

        public double scale
        {
            get
            {
                return Math.Sqrt(sample.sourceArea / template.sourceArea);
            }
        }
    }
}
