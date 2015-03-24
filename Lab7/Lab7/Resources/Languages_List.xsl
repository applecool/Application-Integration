<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="/">
		<html>
			<body>
				<style>
					ul  {					
					padding-top: 0px;
					padding-bottom: 0px;
					align: left;
					margin:0;
					}
				</style>
				<xsl:for-each select="languages/language">
					=== Programming Language <xsl:value-of select="substring-after(@id,'_')" /> ===
					<div style="align:left">
					<ul style="list-style-type:none;">
						<li>
							Language:	<xsl:value-of select="name"/>
						</li>
						<li>
							Intended Use:
							<xsl:variable name="particularuses" ></xsl:variable>
							<xsl:for-each select="intendeduses/intendeduse">
								<xsl:variable name="particularuse" select="@id" />
								<xsl:for-each select="//uses">
									<xsl:variable name="useid" select="use/@uid" />									
										<xsl:if test="$particularuse=$useid">										
											<xsl:value-of  select="use[@uid=$particularuse]"/>										
										</xsl:if>									
								</xsl:for-each>
								<xsl:if test="position() != last()">, </xsl:if>
							</xsl:for-each>							
						</li>
						<li>
							Imperative:
							<xsl:value-of select="imperative"/>
						</li>
						<li>
							Object-Oriented:
							<xsl:value-of select="object-oriented"/>
						</li>
						<li>
							Functional:
							<xsl:value-of select="functional"/>
						</li>
						<li>
							Procedural:
							<xsl:value-of select="procedural"/>
						</li>
						<li>
							Generic:
							<xsl:value-of select="generic"/>
						</li>
						<li>
							Reflective:
							<xsl:value-of select="reflective"/>
						</li>
						<li>
							Event-Driven:
							<xsl:value-of select="event-driven"/>
						</li>
						<li>
							Standard:
							<xsl:for-each select="standardtypes/standardtype">
								<xsl:variable name="particularstandard" select="@id" />
								<xsl:for-each select="//standards">
									<xsl:variable name="standardid" select="type/@tid" />
									<xsl:choose>
										<xsl:when test="$particularstandard=$standardid">
											<xsl:value-of select="type[@tid=$particularstandard]"/>
										</xsl:when>
										<xsl:otherwise>
										</xsl:otherwise>
									</xsl:choose>
								</xsl:for-each>
								<xsl:if test="position() != last()">, </xsl:if>
							</xsl:for-each>
						</li>
					</ul>
						<br></br>
					</div>
				</xsl:for-each>
				A total of  <xsl:value-of select="count(languages/language)"/> programming languages
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>